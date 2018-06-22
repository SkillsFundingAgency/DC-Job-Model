namespace ESFA.DC.Jobs.Model
{
    public class IlrJobMetaData : IJobMetaData
    {
        public string StorageReference { get; set; }
        public string FileName { get; set; }
        public decimal FileSize { get; set; }
        public bool IsFirstStage { get; set; }
        public long JobId { get; set; }
        public int TotalLearners { get; set; }
    }
}
