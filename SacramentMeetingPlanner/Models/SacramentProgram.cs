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
        [DisplayFormat(DataFormatString = "{0:yyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Meeting Date")]
        [Required]
        public DateTime MeetingDate { get; set; }

        [Required]
        public string ConductingLeader { get; set; }

        [Range(1, 341)]
        [Required]
        public int OpeningSong { get; set; }

        public int SacramentHymn { get; set; }

        public int ClosingSong { get; set; }

        public string OptionalSong { get; set; }

        public string OpeningPrayer { get; set; }

        public string ClosingPrayer { get; set; }

        public List<Speaker> Speakers { get; set; }
    }

    public class Speaker
    {
        public int SpeakerId { get; set; }

        public string SpeakerName { get; set; }
        public string SpeakerTopic { get; set; }
    }
}
