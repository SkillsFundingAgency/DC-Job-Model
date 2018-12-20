using System;

namespace ESFA.DC.Api.Models
{
    public class ProviderDetail
    {
        public string Name { get; set; }

        public long Ukprn { get; set; }

        public string LastSubmittedBy { get; set; }

        public DateTime LastSubmittedDateUtc { get; set; }

        public string LastSubmittedByEmail { get; set; }
    }
}
