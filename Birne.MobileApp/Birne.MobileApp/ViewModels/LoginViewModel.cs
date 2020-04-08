using System;
using Prism.Commands;
using Prism.Navigation;

namespace Birne.MobileApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public DelegateCommand LoginCommand { get; private set; }

        public LoginViewModel(INavigationService navigationService) : base(navigationService)
        {
            LoginCommand = new DelegateCommand(Login);
        }

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
        }

        private void Login()
        {
            NavigationService.NavigateAsync("/HomePage");
        }
    }
}
