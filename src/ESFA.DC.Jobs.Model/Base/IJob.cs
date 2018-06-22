using System;
using System.Collections.Generic;
using System.Text;
using ESFA.DC.Jobs.Model.Enums;

namespace ESFA.DC.Jobs.Model
{
    public interface IJob
    {
        long JobId { get; set; }
        JobType JobType { get;}

    }
}
