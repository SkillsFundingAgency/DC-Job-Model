using System.Collections.Generic;

namespace ESFA.DC.Jobs.Model.Reports.ValidationReport
{
    public class IlrValidationResult
    {
        public int TotalLearners { get; set; }

        public int TotalErrors { get; set; }

        public int TotalWarnings { get; set; }

        public int TotalErrorLearners { get; set; }

        public int TotalWarningLearners { get; set; }
    }
}
