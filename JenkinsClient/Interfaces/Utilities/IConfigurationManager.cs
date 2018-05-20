namespace JenkinsClient.Interfaces.Utilities
{
    using System.Collections.Specialized;

    public interface IConfigurationManager
    {
        /// <summary>
        /// Gets all settings associated with the instance of the application
        /// </summary>
        NameValueCollection AppSettings { get; }
    }
}
