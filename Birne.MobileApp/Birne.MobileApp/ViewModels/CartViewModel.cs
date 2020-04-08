using System.Collections.ObjectModel;
using Birne.Core.Models;
using Prism.Navigation;

namespace Birne.MobileApp.ViewModels
{
    public class CartViewModel : BaseViewModel
    {
        private ObservableCollection<ProductModel> _products;

        public ObservableCollection<ProductModel> Products
        {
            get => _products;
            set => RaiseAndSetIfChanged(ref _products, value);
        }

        public CartViewModel(INavigationService navigationService) : base(navigationService)
        {
            Products = new ObservableCollection<ProductModel>();
            Products.Add(new ProductModel());
            Products.Add(new ProductModel());
            Products.Add(new ProductModel());
            Products.Add(new ProductModel());
            Products.Add(new ProductModel());
            Products.Add(new ProductModel());
        }

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
        }
    }
}
