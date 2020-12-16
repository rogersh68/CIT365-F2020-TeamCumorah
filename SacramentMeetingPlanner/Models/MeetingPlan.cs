using System;
using System.ComponentModel.DataAnnotations;

namespace SacramentMeetingPlanner.Models
{
    public class MeetingPlan
    {
        public int MeetingPlanID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Meeting Date")]
        public DateTime MeetingDate { get; set; }

        [Display(Name = "Conducting Leader")]
        public string ConductingLeader { get; set; }

        [Display(Name = "Opening Hymn Number")]
        public int OpeningHymnNumber { get; set; }

        [Display(Name = "Opening Hymn Title")]
        public string OpeningHymnTitle { get; set; }

        [Display(Name = "Opening Prayer")]
        public string OpeningPrayer { get; set; }

        [Display(Name = "Sacrament Hymn Number")]
        public int SacramentHymnNumber { get; set; }

        [Display(Name = "Sacrament Hymn Title")]
        public string SacramentHymnTitle { get; set; }

        [Display(Name = "Intermediate Hymn Number")]
        public int? IntermediateHymnNumber { get; set; }

        [Display(Name = "Intermediate Hymn Title")]
        public string? IntermediateHymnTitle { get; set; }

        [Display(Name = "Closing Hymn Number")]
        public int ClosingHymnNumber { get; set; }

        [Display(Name = "Closing Hymn Title")]
        public string ClosingHymnTitle { get; set; }

        [Display(Name = "Closing Prayer")]
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
