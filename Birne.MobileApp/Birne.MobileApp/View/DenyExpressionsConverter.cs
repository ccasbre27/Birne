using System;
using System.Globalization;
using Xamarin.Forms;

namespace Birne.MobileApp.View
{
    public class DenyExpressionsConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !((bool)value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
