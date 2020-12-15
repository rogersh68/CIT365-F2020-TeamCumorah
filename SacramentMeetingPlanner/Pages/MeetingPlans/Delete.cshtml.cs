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
    public class DeleteModel : PageModel
    {
        private readonly SacramentMeetingPlanner.Models.SacramentMeetingPlannerContext _context;

        public DeleteModel(SacramentMeetingPlanner.Models.SacramentMeetingPlannerContext context)
        {
            _context = context;
        }

        [BindProperty]
        public MeetingPlan MeetingPlan { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MeetingPlan = await _context.MeetingPlan.FirstOrDefaultAsync(m => m.MeetingPlanID == id);

            if (MeetingPlan == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MeetingPlan = await _context.MeetingPlan.FindAsync(id);

            if (MeetingPlan != null)
            {
                _context.MeetingPlan.Remove(MeetingPlan);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
