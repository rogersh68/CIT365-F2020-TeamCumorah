using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SacramentMeetingPlanner.Models;

namespace SacramentMeetingPlanner.Pages.MeetingPlans
{
    public class IndexModel : PageModel
    {
        private readonly SacramentMeetingPlannerContext _context;

        public IndexModel(SacramentMeetingPlannerContext context)
        {
            _context = context;
        }

        public IList<MeetingPlan> MeetingPlan { get;set; }
        public IEnumerable<MeetingSpeaker> MeetingSpeakers { get; set; }
        public int MeetingPlanID { get; set; }
        public string SortByConductingLeader { get; set; }
        public string SortByMeetingDate { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchByConductingLeader { get; set; }

        public async Task OnGetAsync(int? id, string SortMeetingPlan)
        {
            SortByConductingLeader = String.IsNullOrEmpty(SortMeetingPlan) ? "sort_leader_desc" : "";

            SortByMeetingDate = SortMeetingPlan == "MeetingDate" ? "sort_meeting_date_desc" : "MeetingDate";

            var meetingPlans = from m in _context.MeetingPlan
                               select m;

            if (!string.IsNullOrEmpty(SearchByConductingLeader))
            {
                meetingPlans = meetingPlans.Where(s => s.ConductingLeader.Contains(SearchByConductingLeader));
            }

            switch (SortMeetingPlan)
            {
                case "sort_leader_desc":
                    meetingPlans = meetingPlans.OrderByDescending(s => s.ConductingLeader);
                    break;

                case "MeetingDate":
                    meetingPlans = meetingPlans.OrderBy(s => s.MeetingDate);
                    break;

                case "sort_meeting_date_desc":
                    meetingPlans = meetingPlans.OrderByDescending(s => s.MeetingDate);
                    break;

                default:
                    meetingPlans = meetingPlans.OrderBy(s => s.ConductingLeader);
                    break;
            }

            MeetingPlan = await meetingPlans.ToListAsync();

            if (id != null)
            {
                MeetingPlanID = id.Value;

                MeetingSpeakers = _context.MeetingSpeaker.Where(x => x.MeetingPlanID == MeetingPlanID);
            }
        }
    }
}
