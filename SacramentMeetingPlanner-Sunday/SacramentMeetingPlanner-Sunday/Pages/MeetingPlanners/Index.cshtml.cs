using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SacramentMeetingPlanner_Sunday.Models;

namespace SacramentMeetingPlanner_Sunday.Pages.MeetingPlanners
{
    public class IndexModel : PageModel
    {
        private readonly SacramentMeetingPlanner_SundayContext _context;

        public IndexModel(SacramentMeetingPlanner_SundayContext context)
        {
            _context = context;
        }

        public IList<MeetingPlanner> MeetingPlanner { get; set; }
        public IEnumerable<MeetingSpeaker> MeetingSpeakers { get; set; }
        public int MeetingPlannerID { get; set; }

        public async Task OnGetAsync(int? id)
        {
            MeetingPlanner = await _context.MeetingPlanner.ToListAsync();

            if(id != null)
            {
                MeetingPlannerID = id.Value;

                MeetingSpeakers = _context.MeetingSpeaker.Where(x => x.MeetingPlannerID == MeetingPlannerID);
            }
        }
    }
}
