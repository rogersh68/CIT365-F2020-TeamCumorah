using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SacramentMeetingPlanner.Models
{
    public class SacramentProgram
    {
        public int ID { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOfMeeting { get; set; }
        public string ConductingLeader { get; set; }
        public string OpeningSong { get; set; }
        public string SacramentHymn { get; set; }
        public string ClosingSong { get; set; }
        public string IntermediateSong { get; set; }


        public ICollection<SpeakerAssignment> SpeakerAssignments { get; set; }

    }
}
