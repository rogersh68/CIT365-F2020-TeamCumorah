using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SacramentMeetingPlanner_Sunday.Models;

namespace SacramentMeetingPlanner_Sunday.Pages.MeetingSpeakers
{
    public class DeleteModel : PageModel
    {
        private readonly SacramentMeetingPlanner_Sunday.Models.SacramentMeetingPlanner_SundayContext _context;

        public DeleteModel(SacramentMeetingPlanner_Sunday.Models.SacramentMeetingPlanner_SundayContext context)
        {
            _context = context;
        }

        [BindProperty]
        public MeetingSpeaker MeetingSpeaker { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MeetingSpeaker = await _context.MeetingSpeaker.FirstOrDefaultAsync(m => m.MeetingSpeakerID == id);

            if (MeetingSpeaker == null)
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

            MeetingSpeaker = await _context.MeetingSpeaker.FindAsync(id);

            if (MeetingSpeaker != null)
            {
                _context.MeetingSpeaker.Remove(MeetingSpeaker);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
