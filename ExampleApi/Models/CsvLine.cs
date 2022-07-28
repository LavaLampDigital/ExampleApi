using System;

namespace ExampleApi.Models
{
    public class CsvLine
    {
        public DateTime ReportingDate { get; set; }
        
        public string AcademicYear { get; set; }
        
        public string AwardingOrganisation { get; set; }
        
        public string QualificationTitle { get; set; }
        
        public string TypeOfDecisionAppealed { get; set; }
        
        public string GroundOfAppeal { get; set; }
        
        public int AppealsReceived { get; set; }
        
        public int NumberOfCandidates { get; set; }
        
        public int AppealsRejected { get; set; }
        
        public int CompletedAppeal { get; set; }
        
        public int AppealsUpheld { get; set; }
        
        public int AppealsNotUpheld { get; set; }
        
        public int GradesChallenged { get; set; }
        
        public int NoGradeChange { get; set; }
        
        public int GradeChangeUp { get; set; }
        
        public int GradeChangeDown { get; set; }
        
        public int GradeChangeTBD { get; set; }
    }
}