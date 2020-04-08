using System;
using System.Globalization;
using Xamarin.Forms;

namespace Birne.MobileApp.Views
{
    public class ColorConverter : IValueConverter
    {
        private static int count = 0;
        private Color[] colors = new Color[] {
            Color.FromHex("C0DB7C"),
            Color.FromHex("83D2EB"),
            Color.FromHex("F2DA73"),
            Color.FromHex("C8B8F5")
        };
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Color color = colors[count];
            count++;
            if (count == 4)
            {
                count = 0;
            }
            return color;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
