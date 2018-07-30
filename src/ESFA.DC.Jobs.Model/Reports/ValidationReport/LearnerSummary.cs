namespace ESFA.DC.Jobs.Model.Reports.ValidationReport
{
    public class LearnerSummary
    {
        public string Type { get; set; }

        public int CleanLearners { get; set; }

        public int WarningLearners { get; set; }

        public int ErrorLearners { get; set; }
    }
}