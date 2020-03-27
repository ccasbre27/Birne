using System.Collections.ObjectModel;
using Birne.Core;

namespace Birne.MobileApp.ViewModel
{
    public class CartViewModel : BaseViewModel
    {
        private ObservableCollection<Product> _products;

        public ObservableCollection<Product> Products
        {
            get => _products;
            set => RaiseAndSetIfChanged(ref _products, value);
        }

        public CartViewModel()
        {
            Products = new ObservableCollection<Product>();
            Products.Add(new Product());
            Products.Add(new Product());
            Products.Add(new Product());
            Products.Add(new Product());
            Products.Add(new Product());
            Products.Add(new Product());
        }
    }
}
