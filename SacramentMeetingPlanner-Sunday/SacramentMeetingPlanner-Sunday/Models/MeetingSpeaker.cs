using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingPlanner_Sunday.Models
{
    public class MeetingSpeaker
    {
        public int MeetingSpeakerID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Meeting Speaker Name")]
        public string MeetingSpeakerName { get; set; }
        
        [Required]
        [StringLength(80)]
        [Display(Name = "Meeting Speaker Topic")]
        public string MeetingSpeakerTopic { get; set; }

        public int MeetingPlannerID { get; set; }
    }
}
