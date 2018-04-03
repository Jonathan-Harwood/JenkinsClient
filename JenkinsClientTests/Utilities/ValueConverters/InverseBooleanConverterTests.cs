namespace JenkinsClientTests.Utilities.ValueConverters
{
    using System;
    using FluentAssertions;
    using JenkinsClient.Utilities.ValueConverters;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class InverseBooleanConverterTests
    {
        private InverseBooleanConverter inverseBooleanConverter = new InverseBooleanConverter();

        #region Convert
        [TestMethod]
        public void InverseBooleanConverter_Convert_TrueValueSupplied_FalseReturned()
        {
            // Assemble
            bool suppliedValue = true;

            // Action
            object returnedValue = inverseBooleanConverter.Convert(suppliedValue, null, null, null);

            // Assert
            returnedValue.Should().Be(false);
        }

        [TestMethod]
        public void InverseBooleanConverter_Convert_FalseValueSupplied_TrueReturned()
        {
            // Assemble
            bool suppliedValue = false;

            // Action
            object returnedValue = inverseBooleanConverter.Convert(suppliedValue, null, null, null);

            // Assert
            returnedValue.Should().Be(true);
        }

        [TestMethod]
        public void InverseBooleanConverter_Convert_StringValueSupplied_ThrowsInvalidCastException()
        {
            // Assemble
            string suppliedValue = "InvalidParameter";

            // Action
            Action convertAction = () => inverseBooleanConverter.Convert(suppliedValue, null, null, null);

            // Assert
            convertAction.Should().Throw<InvalidCastException>();
        }
        #endregion Convert

        #region ConvertBack
        [TestMethod]
        public void InverseBooleanConverter_ConvertBack_ThrowsNotImplementedException()
        {
            // Action
            Action convertBackAction = () => inverseBooleanConverter.ConvertBack(null, null, null, null);

            // Assert
            convertBackAction.Should().Throw<NotImplementedException>();
        }
        #endregion ConvertBack
    }
}
