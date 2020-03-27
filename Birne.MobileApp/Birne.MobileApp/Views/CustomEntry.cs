using Xamarin.Forms;

namespace Birne.MobileApp.Views
{
    public class CustomEntry : Entry
    {
        public CustomEntry()
        {
            this.HeightRequest = 50;
        }

        public static readonly BindableProperty ImageSourceProperty =
            BindableProperty.Create(nameof(ImageSource), typeof(ImageSource), typeof(CustomEntry), null);

        public static readonly BindableProperty ImageHeightProperty =
            BindableProperty.Create(nameof(ImageHeight), typeof(int), typeof(CustomEntry), 18);

        public static readonly BindableProperty ImageWidthProperty =
            BindableProperty.Create(nameof(ImageWidth), typeof(int), typeof(CustomEntry), 18);

        public static readonly BindableProperty ImageAlignmentProperty =
            BindableProperty.Create(nameof(ImageAlignment), typeof(ImageAlignment), typeof(CustomEntry), ImageAlignment.Left);

        public int ImageWidth
        {
            get { return (int)GetValue(ImageWidthProperty); }
            set { SetValue(ImageWidthProperty, value); }
        }

        public int ImageHeight
        {
            get { return (int)GetValue(ImageHeightProperty); }
            set { SetValue(ImageHeightProperty, value); }
        }

        public ImageSource ImageSource
        {
            get { return (ImageSource)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }

        public ImageAlignment ImageAlignment
        {
            get { return (ImageAlignment)GetValue(ImageAlignmentProperty); }
            set { SetValue(ImageAlignmentProperty, value); }
        }

        public static readonly BindableProperty BorderColorProperty =
      BindableProperty.Create(nameof(BorderColor),
          typeof(Color), typeof(CustomEntry), Color.White);
        // Gets or sets BorderColor value  
        public Color BorderColor
        {
            get => (Color)GetValue(BorderColorProperty);
            set => SetValue(BorderColorProperty, value);
        }

        public static readonly BindableProperty CBackgroundColorProperty =
                BindableProperty.Create(nameof(CBackgroundColor),
                typeof(Color), typeof(CustomEntry), Color.Transparent);

        // Gets or sets BorderColor value  
        public Color CBackgroundColor
        {
            get => (Color)GetValue(CBackgroundColorProperty);
            set
            {
                if (Device.RuntimePlatform == Device.Android)
                {
                    BackgroundColor = Color.Transparent;
                }
                else
                {
                    BackgroundColor = value;
                }

                SetValue(CBackgroundColorProperty, value);
            }
        }

        public static readonly BindableProperty BorderWidthProperty =
        BindableProperty.Create(nameof(BorderWidth), typeof(int),
            typeof(CustomEntry), OnPlatform<int>(1, 2));
        // Gets or sets BorderWidth value  
        public int BorderWidth
        {
            get => (int)GetValue(BorderWidthProperty);
            set => SetValue(BorderWidthProperty, value);
        }
        public static readonly BindableProperty CornerRadiusProperty =
        BindableProperty.Create(nameof(CornerRadius),
            typeof(double), typeof(CustomEntry), OnPlatform<double>(6, 7));

        // Gets or sets CornerRadius value  
        public double CornerRadius
        {
            get => (double)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }

        public static readonly BindableProperty IsCurvedCornersEnabledProperty =
        BindableProperty.Create(nameof(IsCurvedCornersEnabled),
            typeof(bool), typeof(CustomEntry), true);
        // Gets or sets IsCurvedCornersEnabled value  
        public bool IsCurvedCornersEnabled
        {
            get => (bool)GetValue(IsCurvedCornersEnabledProperty);
            set => SetValue(IsCurvedCornersEnabledProperty, value);
        }

        private static T OnPlatform<T>(T iOS, T android)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                return iOS;
            }
            else
            {
                return android;
            }
        }
    }

    public enum ImageAlignment
    {
        Left,
        Right
    }
}
