namespace EduPrime.Infrastructure.AzureServices
{
    /// <summary>
    /// Azure settings
    /// </summary>
    public class AzureSettings
    {
        /// <summary>
        /// Storage account key (connection string)
        /// </summary>
        public string StorageAccountKey { get; set; }

        /// <summary>
        /// Employees RFCs storage container name
        /// </summary>
        public string EmployeesRfcsContainer { get; set; }

        /// <summary>
        /// Employees pictures storage container name
        /// </summary>
        public string EmployeesPicturesContainer { get; set; }
    }
}
