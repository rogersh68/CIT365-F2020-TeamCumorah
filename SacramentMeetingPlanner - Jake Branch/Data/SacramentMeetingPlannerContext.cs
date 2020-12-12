using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SacramentMeetingPlanner.Models;

namespace SacramentMeetingPlanner.Data
{
    public class SacramentMeetingPlannerContext : DbContext
    {
        public SacramentMeetingPlannerContext (DbContextOptions<SacramentMeetingPlannerContext> options)
            : base(options)
        {
        }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
        public DbSet<SacramentProgram> SacramentPrograms { get; set; }
        public DbSet<SpeakerAssignment> SpeakerAssignments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Speaker>().ToTable("Speaker");
            modelBuilder.Entity<Assignment>().ToTable("Assignment");
            modelBuilder.Entity<SacramentProgram>().ToTable("SacramentProgram");
            modelBuilder.Entity<SpeakerAssignment>().ToTable("SpeakerAssignment");

            modelBuilder.Entity<SpeakerAssignment>()
           .HasKey(c => new { c.SpeakerID, c.ProgramID });
        }
    }
}
