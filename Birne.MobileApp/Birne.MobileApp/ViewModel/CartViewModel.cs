using Birne.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Birne.MobileApp.ViewModel
{
    public class CartViewModel : BaseViewModel
    {
        private ObservableCollection<Products> _products;

        public ObservableCollection<Products> Products
        {
            get => _products;
            set => RaiseAndSetIfChanged(ref _products, value);
        }

        public CartViewModel() 
        {
            Products = new ObservableCollection<Products>();
            Products.Add(new Products());
            Products.Add(new Products());
            Products.Add(new Products());
            Products.Add(new Products());
            Products.Add(new Products());
            Products.Add(new Products());
        }
    }
}
