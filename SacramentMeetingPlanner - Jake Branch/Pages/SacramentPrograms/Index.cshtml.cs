using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SacramentMeetingPlanner.Data;
using SacramentMeetingPlanner.Models;

namespace SacramentMeetingPlanner.Pages.SacramentPrograms
{
    public class IndexModel : PageModel
    {
        private readonly SacramentMeetingPlanner.Data.SacramentMeetingPlannerContext _context;

        public IndexModel(SacramentMeetingPlanner.Data.SacramentMeetingPlannerContext context)
        {
            _context = context;
        }

        public SacramentProgramIndexData SacramentProgramData { get; set; }
        public int ProgramID { get; set; }
        public int SpeakerID { get; set; }

        public async Task OnGetAsync(int? id, int? speakerID)
        {
            SacramentProgramData = new SacramentProgramIndexData();
            SacramentProgramData.SacramentPrograms = await _context.SacramentPrograms
                .Include(i => i.SpeakerAssignments)
                    .ThenInclude(i => i.Speaker)
                .ToListAsync();

            if (id != null)
            {
                ProgramID = id.Value;
                SacramentProgram SacramentProgram = SacramentProgramData.SacramentPrograms
                    .Where(i => i.ID == id.Value).Single();
                SacramentProgramData.Speakers = SacramentProgram.SpeakerAssignments.Select(s => s.Speaker);
            }

            if (speakerID != null)
            {
                SpeakerID = speakerID.Value;
                var selectedCourse = SacramentProgramData.Speakers
                    .Where(x => x.SpeakerID == speakerID).Single();
                await _context.Entry(selectedCourse).Collection(x => x.Assignments).LoadAsync();
                SacramentProgramData.Assignments = selectedCourse.Assignments;
            }
        }
    }
}
