﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SacramentMeetingPlanner.Models
{
    public class SacramentMeetingPlannerContext : DbContext
    {
        public SacramentMeetingPlannerContext (DbContextOptions<SacramentMeetingPlannerContext> options)
            : base(options)
        {
        }

        public DbSet<SacramentMeetingPlanner.Models.SacramentProgram> SacramentProgram { get; set; }
        public DbSet<SacramentMeetingPlanner.Models.Speaker> Speakers { get; set; }
    }
}
