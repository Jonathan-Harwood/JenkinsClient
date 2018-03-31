namespace JenkinsClientTests.Utilities.ValueConverters
{
    using System;
    using FluentAssertions;
    using JenkinsClient.Utilities.ValueConverters;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DoubleDefaultConverterTests
    {
        private DoubleDefaultConverter doubleDefaultConverter = new DoubleDefaultConverter();

        #region Convert
        [TestMethod]
        public void DoubleDefaultConverter_Convert_ReturnsSuppliedValue_IfValueIsDouble()
        {
            // Assemble
            double suppliedValue = 3.6;
            double defaultParameter = 4;

            // Action
            object returnedValue = doubleDefaultConverter.Convert(suppliedValue, null, defaultParameter, null);

            // Assert
            returnedValue.Should().Be(suppliedValue);
        }

        [TestMethod]
        public void DoubleDefaultConverter_Convert_ReturnsSuppliedValue_IfValueIsInteger()
        {
            // Assemble
            int suppliedValue = 3;
            int defaultParameter = 4;

            // Action
            object returnedValue = doubleDefaultConverter.Convert(suppliedValue, null, defaultParameter, null);

            // Assert
            returnedValue.Should().Be(suppliedValue);
        }

        [TestMethod]
        public void DoubleDefaultConverter_Convert_ReturnsDefaultParameter_IfValueIsString()
        {
            // Assemble
            string suppliedValue = "InvalidParameter";
            int defaultParameter = 4;

            // Action
            object returnedValue = doubleDefaultConverter.Convert(suppliedValue, null, defaultParameter, null);

            // Assert
            returnedValue.Should().Be(defaultParameter);
        }
        #endregion Convert

        #region ConvertBack
        [TestMethod]
        public void DoubleDefaultConverter_ConvertBack_ThrowsNotImplementedException()
        {
            // Action
            Action convertBackAction = () => doubleDefaultConverter.ConvertBack(null, null, null, null);

            // Assert
            convertBackAction.Should().Throw<NotImplementedException>();
        }
        #endregion ConvertBack
    }
}
