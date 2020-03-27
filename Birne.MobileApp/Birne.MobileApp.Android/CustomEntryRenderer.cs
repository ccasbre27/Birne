using System;
using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Util;
using AndroidX.Core.Content;
using Birne.MobileApp.Droid.Controls;
using Birne.MobileApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace Birne.MobileApp.Droid.Controls
{
    public class CustomEntryRenderer : EntryRenderer
    {
        CustomEntry element;
        public CustomEntryRenderer(Context context) : base(context)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null || e.NewElement == null)
                return;

            element = (CustomEntry)this.Element;

            if (element.IsCurvedCornersEnabled)
            {
                // creating gradient drawable for the curved background  
                var _gradientBackground = new GradientDrawable();
                _gradientBackground.SetShape(ShapeType.Rectangle);
                _gradientBackground.SetColor(element.CBackgroundColor.ToAndroid());

                // Thickness of the stroke line
                _gradientBackground.SetStroke(element.BorderWidth, element.BorderColor.ToAndroid());

                // Radius for the curves
                _gradientBackground.SetCornerRadius(
                    DpToPixels(this.Context,
                    Convert.ToSingle(element.CornerRadius)));

                // set the background of the label
                Control.SetBackground(_gradientBackground);
            }

            // Set padding for the internal text from border  
            Control.SetPadding(
                (int)DpToPixels(this.Context, Convert.ToSingle(12)), Control.PaddingTop,
                (int)DpToPixels(this.Context, Convert.ToSingle(12)), Control.PaddingBottom);

            var editText = this.Control;
            if (element.ImageSource != null)
            {
                switch (element.ImageAlignment)
                {
                    case ImageAlignment.Left:
                        editText.SetCompoundDrawablesWithIntrinsicBounds(GetDrawable(element.ImageSource), null, null, null);
                        break;
                    case ImageAlignment.Right:
                        editText.SetCompoundDrawablesWithIntrinsicBounds(null, null, GetDrawable(element.ImageSource), null);
                        break;
                }
            }

            editText.CompoundDrawablePadding = 25;
            //Control.Background.SetColorFilter(element.BorderColor.ToAndroid(), PorterDuff.Mode.SrcAtop);
        }

        public static float DpToPixels(Context context, float valueInDp)
        {
            DisplayMetrics metrics = context.Resources.DisplayMetrics;
            return TypedValue.ApplyDimension(ComplexUnitType.Dip, valueInDp, metrics);
        }

        private BitmapDrawable GetDrawable(ImageSource customEntryImage)
        {
            var icon = (FileImageSource)customEntryImage;

            if (icon == null)
            {
                return null;
            }

            int resID = Resources.GetIdentifier(icon.File.Split(".")[0], "drawable", this.Context.PackageName);
            var drawable = ContextCompat.GetDrawable(this.Context, resID);
            var bitmap = ((BitmapDrawable)drawable).Bitmap;

            return new BitmapDrawable(Resources, Bitmap.CreateScaledBitmap(bitmap, element.ImageWidth * 2, element.ImageHeight * 2, true));
        }
    }
}