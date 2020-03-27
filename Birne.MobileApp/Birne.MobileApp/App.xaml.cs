using System;
using System.Reflection;
using Birne.MobileApp.Views;
using Birne.MobileApp.ViewModels;
using Prism.Ioc;
using Prism.Mvvm;
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

            //MainPage = new HomePage();
            NavigationService.NavigateAsync($"LoginPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<HomePage, HomeViewModel>();
            containerRegistry.RegisterForNavigation<LoginPage, LoginViewModel>();
            containerRegistry.RegisterForNavigation<RegisterUserPage, RegisterUserViewModel>();
            containerRegistry.RegisterForNavigation<CartPage, CartViewModel>();
            containerRegistry.RegisterForNavigation<MainPage>();
        }

        protected override void ConfigureViewModelLocator()
        {
            base.ConfigureViewModelLocator();

            ViewModelLocationProvider.SetDefaultViewTypeToViewModelTypeResolver((viewType) =>
            {
                var viewName = viewType.FullName.Replace(".Views.", ".ViewModels.").Replace("Page", "");
                var viewAssemblyName = viewType.GetTypeInfo().Assembly.FullName;
                var viewModelName = $"{viewName}ViewModel, {viewAssemblyName}";
                return Type.GetType(viewModelName);
            });
        }
    }
}
