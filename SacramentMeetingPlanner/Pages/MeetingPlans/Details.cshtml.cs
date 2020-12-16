using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SacramentMeetingPlanner.Models;

namespace SacramentMeetingPlanner.Pages.MeetingPlans
{
    public class DetailsModel : PageModel
    {
        private readonly SacramentMeetingPlannerContext _context;

        public DetailsModel(SacramentMeetingPlannerContext context)
        {
            _context = context;
        }

        public MeetingPlan MeetingPlan { get; set; }
        public IEnumerable<MeetingSpeaker> Speakers { get; set; }
        public int MeetingPlanID { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MeetingPlanID = id.Value;
            MeetingPlan = await _context.MeetingPlan.FirstOrDefaultAsync(m => m.MeetingPlanID == id);
            Speakers = _context.MeetingSpeaker.Where(x => x.MeetingPlanID == MeetingPlanID);

            if (MeetingPlan == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
