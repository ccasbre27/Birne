using System;
using System.Collections;
using System.Globalization;
using Xamarin.Forms;

namespace Birne.MobileApp.Views
{
    public class HeigthConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return 0;
            }
            var collection = value as ICollection;
            return ((collection.Count + 1) / 2) * System.Convert.ToDecimal(parameter);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
