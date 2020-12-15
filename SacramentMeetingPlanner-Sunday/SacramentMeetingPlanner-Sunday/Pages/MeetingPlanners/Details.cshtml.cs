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
    public class DetailsModel : PageModel
    {
        private readonly SacramentMeetingPlanner_SundayContext _context;

        public DetailsModel(SacramentMeetingPlanner_SundayContext context)
        {
            _context = context;
        }

        public MeetingPlanner MeetingPlanner { get; set; }
        public IEnumerable<MeetingSpeaker> Speakers { get; set; }
        public int MeetingPlannerID { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MeetingPlannerID = id.Value;
            MeetingPlanner = await _context.MeetingPlanner.FirstOrDefaultAsync(m => m.MeetingPlannerID == id);
            Speakers = _context.MeetingSpeaker.Where(x => x.MeetingPlannerID == MeetingPlannerID);

            if (MeetingPlanner == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
