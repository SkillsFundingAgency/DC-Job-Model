﻿using System;
using System.Collections.Generic;
using System.Text;
using ESFA.DC.Jobs.Model.Enums;
using ESFA.DC.JobStatus.Interface;

namespace ESFA.DC.Jobs.Model
{
    public class Job
    {
        public long JobId { get; set; }

        public JobType JobType { get; set; }

        public JobStatusType Status { get; set; }

        public short Priority { get; set; }

        public DateTime DateTimeSubmittedUtc { get; set; }

        public DateTime? DateTimeUpdatedUtc { get; set; }

        public string RowVersion { get; set; }

        public string SubmittedBy { get; set; }

        public string NotifyEmail { get; set; }

        public JobStatusType CrossLoadingStatus { get; set; }
    }
}
