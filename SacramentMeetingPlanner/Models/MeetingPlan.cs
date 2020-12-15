using System;
using System.ComponentModel.DataAnnotations;

namespace SacramentMeetingPlanner.Models
{
    public class MeetingPlan
    {
        public int MeetingPlanID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Meeting Date")]
        [Required]
        public DateTime MeetingDate { get; set; }

        [Display(Name = "Conducting Leader")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string ConductingLeader { get; set; }

        [Display(Name = "Opening Hymn Number")]
        [Range(1, 341)]
        [Required]
        public int OpeningHymnNumber { get; set; }

        [Display(Name = "Opening Hymn Title")]
        [StringLength(80, MinimumLength = 3)]
        [Required]
        public string OpeningHymnTitle { get; set; }

        [Display(Name = "Opening Prayer")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string OpeningPrayer { get; set; }

        [Display(Name = "Sacrament Hymn Number")]
        [Range(1, 341)]
        [Required]
        public int SacramentHymnNumber { get; set; }

        [Display(Name = "Sacrament Hymn Title")]
        [StringLength(80, MinimumLength = 3)]
        [Required]
        public string SacramentHymnTitle { get; set; }

        [Display(Name = "Intermediate Hymn Number")]
        [Range(1, 341)]
        public int? IntermediateHymnNumber { get; set; }

        [Display(Name = "Intermediate Hymn Title")]
        [StringLength(80, MinimumLength = 3)]
        public string? IntermediateHymnTitle { get; set; }

        [Display(Name = "Closing Hymn Number")]
        [Range(1, 341)]
        [Required]
        public int ClosingHymnNumber { get; set; }

        [Display(Name = "Closing Hymn Title")]
        [StringLength(80, MinimumLength = 3)]
        [Required]
        public string ClosingHymnTitle { get; set; }

        [Display(Name = "Closing Prayer")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string ClosingPrayer { get; set; }

        public string GetOpeningHymn()
        {
            return $"{OpeningHymnNumber} - {OpeningHymnTitle}";
        }

        public string GetSacramentHymn()
        {
            return $"{SacramentHymnNumber} - {SacramentHymnTitle}";
        }

        public string GetIntermediategHymn()
        {
            return $"{IntermediateHymnNumber} - {IntermediateHymnTitle}";
        }

        public string GetClosingHymn()
        {
            return $"{ClosingHymnNumber} - {ClosingHymnTitle}";
        }
    }
}
