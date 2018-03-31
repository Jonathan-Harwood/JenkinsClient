namespace JenkinsClient.Utilities.ValueConverters
{
    using System;
    using System.Globalization;
    using System.Windows.Data;

    public class DoubleDefaultConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                // Try and convert supplied value to a double
                return System.Convert.ToDouble(value);
            }
            catch (FormatException)
            {
                // Use default parameter
                return parameter;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
