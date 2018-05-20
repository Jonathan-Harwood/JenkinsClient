namespace JenkinsClientTests.Utilities
{
    using System.Collections.Specialized;
    using FluentAssertions;
    using JenkinsClient.Utilities;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ConfigurationManagerTests
    {
        #region AppSettings
        [TestMethod]
        public void ConfigurationManager_AppSettings_ReturnsInstanceAppSettings()
        {
            // Assemble
            NameValueCollection expectedAppSettings = System.Configuration.ConfigurationManager.AppSettings;
            ConfigurationManager configurationManager = CreateConfigurationManager();

            // Action
            NameValueCollection actualAppSettings = configurationManager.AppSettings;

            // Assert
            actualAppSettings.Should().BeEquivalentTo(expectedAppSettings);
        }
        #endregion AppSettings

        #region Private Helper Methods
        private ConfigurationManager CreateConfigurationManager()
        {
            return new ConfigurationManager();
        }
        #endregion Private Helper Methods
    }
}
