using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SacramentMeetingPlanner.Models;

namespace SacramentMeetingPlanner.Pages.MeetingSpeakers
{
    public class CreateModel : PageModel
    {
        private readonly SacramentMeetingPlannerContext _context;

        public CreateModel(SacramentMeetingPlannerContext context)
        {
            _context = context;
        }

        public int MeetingPlanID { get; set; }

        public IActionResult OnGet(int meetingPlanID)
        {
            MeetingPlanID = meetingPlanID;
            return Page();
        }

        [BindProperty]
        public MeetingSpeaker MeetingSpeaker { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.MeetingSpeaker.Add(MeetingSpeaker);
            await _context.SaveChangesAsync();

            return Redirect($"/MeetingPlans/Index?id={MeetingSpeaker.MeetingPlanID}");
        }
    }
}
