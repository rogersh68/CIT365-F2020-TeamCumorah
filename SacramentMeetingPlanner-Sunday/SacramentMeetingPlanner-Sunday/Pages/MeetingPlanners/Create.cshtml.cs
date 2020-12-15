using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SacramentMeetingPlanner_Sunday.Models;

namespace SacramentMeetingPlanner_Sunday.Pages.MeetingPlanners
{
    public class CreateModel : PageModel
    {
        private readonly SacramentMeetingPlanner_Sunday.Models.SacramentMeetingPlanner_SundayContext _context;

        public CreateModel(SacramentMeetingPlanner_Sunday.Models.SacramentMeetingPlanner_SundayContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public MeetingPlanner MeetingPlanner { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.MeetingPlanner.Add(MeetingPlanner);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}