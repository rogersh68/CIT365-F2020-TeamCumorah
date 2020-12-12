namespace SacramentMeetingPlanner.Models
{
    public class SpeakerAssignment
    {
        public int ProgramID { get; set; }
        public int SpeakerID { get; set; }
        public SacramentProgram SacramentProgram { get; set; }
        public Speaker Speaker { get; set; }
    }
}
