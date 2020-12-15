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
    public class IndexModel : PageModel
    {
        private readonly SacramentMeetingPlanner_Sunday.Models.SacramentMeetingPlanner_SundayContext _context;

        public IndexModel(SacramentMeetingPlanner_Sunday.Models.SacramentMeetingPlanner_SundayContext context)
        {
            _context = context;
        }

        public IList<MeetingSpeaker> MeetingSpeaker { get;set; }

        public async Task OnGetAsync()
        {
            MeetingSpeaker = await _context.MeetingSpeaker.ToListAsync();
        }
    }
}
