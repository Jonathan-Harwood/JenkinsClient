namespace JenkinsClientTests.Utilities
{
    using System;
    using FluentAssertions;
    using JenkinsClient.Utilities;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ValidationExtensionsTests
    {
        #region EnsureIsNotNull
        [TestMethod]
        public void ValidationExtensions_EnsureIsNotNull_NullParameter_ThrowsArgumentNullException()
        {
            // Assemble
            string appSettingsParameter = null;
            string appSettingsMessage = "appSettings";
            string exceptionMessage = $"Value cannot be null.\nParameter name: {appSettingsMessage}";

            // Action
            Action ensureIsNotNullAction = () => ValidationExtensions.EnsureIsNotNull(appSettingsParameter, appSettingsMessage);

            // Assert
            ensureIsNotNullAction.Should().Throw<ArgumentNullException>().WithMessage(exceptionMessage);
        }

        [TestMethod]
        public void ValidationExtensions_EnsureIsNotNull_NonNullParameter_DoesNotThrowArgumentNullException()
        {
            // Assemble
            string appSettingsParameter = "appSettings";
            string appSettingsMessage = "appSettings";

            // Action
            Action ensureIsNotNullAction = () => ValidationExtensions.EnsureIsNotNull(appSettingsParameter, appSettingsMessage);

            // Assert
            ensureIsNotNullAction.Should().NotThrow<ArgumentNullException>();
        }
        #endregion EnsureIsNotNull
    }
}
