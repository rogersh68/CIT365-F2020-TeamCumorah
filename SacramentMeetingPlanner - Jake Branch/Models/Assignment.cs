using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SacramentMeetingPlanner.Models
{
    public class Assignment
    {

        public int AssignmentID { get; set; }
        public int SpeakerID { get; set; }
        public int ProgramID { get; set; }

        public Speaker Speaker { get; set; }
    }
}
