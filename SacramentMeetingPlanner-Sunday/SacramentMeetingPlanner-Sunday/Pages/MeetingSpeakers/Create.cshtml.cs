using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SacramentMeetingPlanner_Sunday.Models;

namespace SacramentMeetingPlanner_Sunday.Pages.MeetingSpeakers
{
    public class CreateModel : PageModel
    {
        private readonly SacramentMeetingPlanner_SundayContext _context;

        public CreateModel(SacramentMeetingPlanner_SundayContext context)
        {
            _context = context;
        }

        public int MeetingPlannerID { get; set; }

        public IActionResult OnGet(int meetingPlannerID)
        {
            MeetingPlannerID = meetingPlannerID;
            return Page();
        }

        [BindProperty]
        public MeetingSpeaker MeetingSpeaker { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.MeetingSpeaker.Add(MeetingSpeaker);
            await _context.SaveChangesAsync();

            return Redirect($"/MeetingPlanners/Index?id={MeetingSpeaker.MeetingPlannerID}");
        }
    }
}