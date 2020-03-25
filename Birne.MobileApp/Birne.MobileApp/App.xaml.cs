using Prism.Ioc;
using Prism.Unity;

namespace Birne.MobileApp
{
    public partial class App : PrismApplication
    {
        public App()
        {
            InitializeComponent();
        }

        protected override void OnInitialized()
        {
            MainPage = new MainPage();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
    }
}
