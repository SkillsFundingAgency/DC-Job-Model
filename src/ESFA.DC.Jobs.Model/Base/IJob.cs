using ESFA.DC.Jobs.Model.Enums;

namespace ESFA.DC.Jobs.Model.Base
{
    public interface IJob
    {
        long JobId { get; set; }
        JobType JobType { get;}

    }
}
