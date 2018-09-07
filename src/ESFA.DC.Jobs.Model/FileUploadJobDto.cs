using System;

namespace ESFA.DC.Jobs.Model
{
    public class FileUploadJobDto
    {
        public short JobType { get; set; }

        public long? Ukprn { get; set; }

        public short Priority { get; set; }

        public DateTime DateTimeSubmittedUtc { get; set; }

        public DateTime? DateTimeUpdatedUtc { get; set; }

        public short Status { get; set; }

        public string RowVersion { get; set; }

        public string SubmittedBy { get; set; }

        public string StorageReference { get; set; }

        public string FileName { get; set; }

        public decimal FileSize { get; set; }

        public bool IsFirstStage { get; set; }

        public long JobId { get; set; }

        public int PeriodNumber { get; set; }

        public string CollectionName { get; set; }

        public string NotifyEmail { get; set; }
    }
}
