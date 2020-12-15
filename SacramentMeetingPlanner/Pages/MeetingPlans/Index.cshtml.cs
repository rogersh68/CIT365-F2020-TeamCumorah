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

        public async Task OnGetAsync(int? id)
        {
            MeetingPlan = await _context.MeetingPlan.ToListAsync();

            if (id != null)
            {
                MeetingPlanID = id.Value;

                MeetingSpeakers = _context.MeetingSpeaker.Where(x => x.MeetingPlanID == MeetingPlanID);
            }
        }
    }
}
