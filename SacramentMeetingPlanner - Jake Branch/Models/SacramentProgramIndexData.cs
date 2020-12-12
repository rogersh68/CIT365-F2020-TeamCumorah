using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingPlanner.Models
{
    public class SacramentProgramIndexData
    {
        public IEnumerable<SacramentProgram> SacramentPrograms { get; set; }
        public IEnumerable<Speaker> Speakers { get; set; }
        public IEnumerable<Assignment> Assignments { get; set; }
    }
}
