using System;
using Xamarin.Forms;

namespace Birne.MobileApp.Views
{
    public partial class Stepper : ContentView
    {
        public static readonly BindableProperty ValueProperty =
            BindableProperty.Create(nameof(Value), typeof(int), typeof(Stepper), 1);

        public int Value
        {
            get { return (int)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        public Stepper()
        {
            InitializeComponent();
        }

        private void DownTapped(object sender, EventArgs args)
        {
            if (Value == 1)
                return;

            Value--;
        }

        private void UpTapped(object sender, EventArgs args)
        {
            if (Value == 999)
                return;

            Value++;
        }
    }
}
