using System;
using ESFA.DC.Jobs.Model.Enums;
using ESFA.DC.JobStatus.Interface;

namespace ESFA.DC.Jobs.Model.Base
{
    public interface IJob
    {
        long JobId { get; set; }

        JobType JobType { get;}

        JobStatusType Status { get; set; }

        short Priority { get; set; }

        DateTime DateTimeSubmittedUtc { get; set; }

        string RowVersion { get; set; }

        string SubmittedBy { get; set; }

    }
}
