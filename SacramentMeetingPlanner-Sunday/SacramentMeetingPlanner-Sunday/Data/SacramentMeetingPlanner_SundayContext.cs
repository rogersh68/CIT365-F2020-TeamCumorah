using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SacramentMeetingPlanner_Sunday.Models;

namespace SacramentMeetingPlanner_Sunday.Models
{
    public class SacramentMeetingPlanner_SundayContext : DbContext
    {
        public SacramentMeetingPlanner_SundayContext (DbContextOptions<SacramentMeetingPlanner_SundayContext> options)
            : base(options)
        {
        }

        public DbSet<SacramentMeetingPlanner_Sunday.Models.MeetingPlanner> MeetingPlanner { get; set; }

        public DbSet<SacramentMeetingPlanner_Sunday.Models.MeetingSpeaker> MeetingSpeaker { get; set; }
    }
}
