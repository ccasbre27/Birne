using System;
using Birne.Core.Models;
using Prism.Commands;
using Prism.Navigation;

namespace Birne.MobileApp.ViewModels
{
    public class ProductDetailPageViewModel : BaseViewModel
    {
        #region Instances
        private ProductModel _product;

        public ProductModel Product
        {
            get => _product;
            set => RaiseAndSetIfChanged(ref _product, value);
        }
        #endregion

        #region Commands
        public DelegateCommand GoToBackCommand { get; private set; }
        #endregion

        #region Private Methods
        public ProductDetailPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            GoToBackCommand = new DelegateCommand(GoToBack);
        }

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            Product = parameters[nameof(ProductModel)] as ProductModel;
        }

        private void GoToBack()
        {
            NavigationService.GoBackAsync();
        }
        #endregion
    }
}
