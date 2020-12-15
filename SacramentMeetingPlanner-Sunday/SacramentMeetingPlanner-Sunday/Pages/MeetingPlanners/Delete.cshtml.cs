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
    public class DeleteModel : PageModel
    {
        private readonly SacramentMeetingPlanner_Sunday.Models.SacramentMeetingPlanner_SundayContext _context;

        public DeleteModel(SacramentMeetingPlanner_Sunday.Models.SacramentMeetingPlanner_SundayContext context)
        {
            _context = context;
        }

        [BindProperty]
        public MeetingPlanner MeetingPlanner { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MeetingPlanner = await _context.MeetingPlanner.FirstOrDefaultAsync(m => m.MeetingPlannerID == id);

            if (MeetingPlanner == null)
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

            MeetingPlanner = await _context.MeetingPlanner.FindAsync(id);

            if (MeetingPlanner != null)
            {
                _context.MeetingPlanner.Remove(MeetingPlanner);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
