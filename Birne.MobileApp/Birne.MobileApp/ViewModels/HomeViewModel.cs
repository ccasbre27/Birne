using Birne.MobileApp.Core.Interface;
using Prism.Commands;
using Prism.Navigation;
using System;
using Xamarin.Forms;

namespace Birne.MobileApp.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        private ISpeechToText _speechRecongnitionInstance;

        public DelegateCommand SpeechCommand { get; private set; }

        public HomeViewModel(INavigationService navigationService) : base(navigationService)
        {
            SpeechCommand = new DelegateCommand(StartSpeechRecognition);

            try
            {
                _speechRecongnitionInstance = DependencyService.Get<ISpeechToText>();
            }
            catch (Exception ex)
            {
                //recon.Text = ex.Message;
            }
        }

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
        }

        public void StartSpeechRecognition()
        {
            try
            {
                _speechRecongnitionInstance.StartSpeechToText();
            }
            catch (Exception ex)
            {
                //recon.Text = ex.Message;
            }

            if (Device.RuntimePlatform == Device.iOS)
            {
                //start.IsEnabled = false;
            }
        }
    }
}
