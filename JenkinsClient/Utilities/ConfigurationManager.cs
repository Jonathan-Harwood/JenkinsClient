namespace JenkinsClient.Utilities
{
    using System.Collections.Specialized;
    using JenkinsClient.Interfaces.Utilities;

    public class ConfigurationManager : IConfigurationManager
    {
        public NameValueCollection AppSettings
        {
            get
            {
                return System.Configuration.ConfigurationManager.AppSettings;
            }
        }
    }
}
