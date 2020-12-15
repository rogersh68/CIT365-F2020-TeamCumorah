using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SacramentMeetingPlanner.Models;

namespace SacramentMeetingPlanner.Pages.MeetingPlans
{
    public class EditModel : PageModel
    {
        private readonly SacramentMeetingPlanner.Models.SacramentMeetingPlannerContext _context;

        public EditModel(SacramentMeetingPlanner.Models.SacramentMeetingPlannerContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(MeetingPlan).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MeetingPlanExists(MeetingPlan.MeetingPlanID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MeetingPlanExists(int id)
        {
            return _context.MeetingPlan.Any(e => e.MeetingPlanID == id);
        }
    }
}
