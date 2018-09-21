using System;
using ESFA.DC.Jobs.Model.Enums;
using ESFA.DC.JobStatus.Interface;

namespace ESFA.DC.Jobs.Model
{
    public class FileUploadJob
    {
        public JobType JobType { get; set; }

        public long Ukprn { get; set; }

        public short Priority { get; set; }

        public DateTime DateTimeSubmittedUtc { get; set; }

        public DateTime? DateTimeUpdatedUtc { get; set; }

        public JobStatusType Status { get; set; }

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

        public bool IsCrossLoaded { get; set; }
    }
}
