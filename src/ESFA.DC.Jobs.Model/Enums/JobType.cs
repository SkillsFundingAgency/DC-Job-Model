namespace ESFA.DC.Jobs.Model.Enums
{
    /// <summary>
    /// The enum representing the possible job types in the system.
    /// This enum must be kept up to date with [JobManagement].[dbo].[JobType]
    /// </summary>
    public enum JobType
    {
        IlrSubmission = 1,
        EasSubmission = 2,
        EsfSubmission = 3,
        PeriodEnd = 20,
        ReferenceDataEPA = 40,
        ReferenceDataFCS = 41
    }
}
