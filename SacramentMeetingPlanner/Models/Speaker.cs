using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SacramentMeetingPlanner.Models
{
    public class Speaker
    {
        public int SpeakerID { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public ICollection<Assignment> Assignments { get; set; }
        public ICollection<SpeakerAssignment> SpeakerAssignments { get; set; }
    }
}
