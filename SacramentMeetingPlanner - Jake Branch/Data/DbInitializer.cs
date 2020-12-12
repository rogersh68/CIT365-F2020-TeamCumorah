using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SacramentMeetingPlanner.Data;
using SacramentMeetingPlanner.Models;

namespace SacramentMeetingPlanner.Data
{
    public class DbInitializer
    {

        public static void Initialize(SacramentMeetingPlannerContext context)
        {
            context.Database.EnsureCreated();
            context.SaveChanges();

            var speakers = new Speaker[]
            {
                new Speaker{SpeakerID=0,Name="John Smith", Subject="Gospel"},
                new Speaker{SpeakerID=1,Name="John Smith", Subject="Gospel"},
                new Speaker{SpeakerID=2,Name="John Smith", Subject="Gospel"},
                new Speaker{SpeakerID=3,Name="John Smith", Subject="Gospel"},
                new Speaker{SpeakerID=4,Name="John Smith", Subject="Gospel"},
                new Speaker{SpeakerID=5,Name="John Smith", Subject="Gospel"},
                new Speaker{SpeakerID=6,Name="John Smith", Subject="Gospel"},
            };

            context.Speakers.AddRange(speakers);
            context.SaveChanges();

            var assignments = new Assignment[]
            {
                new Assignment{SpeakerID=0},
                new Assignment{SpeakerID=0},
                new Assignment{SpeakerID=1},
                new Assignment{SpeakerID=1},
                new Assignment{SpeakerID=1},
                new Assignment{SpeakerID=2},
                new Assignment{SpeakerID=2},
            };

            context.Assignments.AddRange(assignments);
            context.SaveChanges();
        }
    }
}
