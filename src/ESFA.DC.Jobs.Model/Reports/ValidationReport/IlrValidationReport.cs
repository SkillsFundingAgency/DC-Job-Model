using System.Collections.Generic;

namespace ESFA.DC.Jobs.Model.Reports.ValidationReport
{
    public class IlrValidationReport
    {
        public int TotalErrors { get; set; }

        public int TotalWarnings { get; set; }

        public int WarningLearners { get; set; }

        public int ErrorLearners { get; set; }

        public IEnumerable<LearnerSummary> LearnerSummaries { get; set; }

        public IEnumerable<LearningDeliverySummary> LearningDeliverySummaries { get; set; }

        public IEnumerable<LearnerDestinationProgressionSummary> LearnerDestinationProgressionSummaries { get; set; }
    }
}
