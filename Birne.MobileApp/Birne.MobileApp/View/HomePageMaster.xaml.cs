
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Birne.MobileApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePageMaster : ContentPage
    {
        public ListView ListView;

        public HomePageMaster()
        {
            InitializeComponent();
        }
    }
}
