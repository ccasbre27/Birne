using Birne.MobileApp.View;
using Birne.MobileApp.ViewModel;
using Prism.Ioc;
using Prism.Unity;
using Xamarin.Forms;

namespace Birne.MobileApp
{
    public partial class App : PrismApplication
    {
        public App()
        {
        }

        protected override void OnInitialized()
        {
            InitializeComponent();

            MainPage = new HomePage();
            //NavigationService.NavigateAsync($"HomePage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<HomePage, HomeViewModel>();
            containerRegistry.RegisterForNavigation<LoginPage, LoginViewModel>();
            containerRegistry.RegisterForNavigation<RegisterUserPage, RegisterUserViewModel>();
            containerRegistry.RegisterForNavigation<HomeTabPage, HomeTabViewModel>();
            containerRegistry.RegisterForNavigation<MainPage>();
        }
    }
}
