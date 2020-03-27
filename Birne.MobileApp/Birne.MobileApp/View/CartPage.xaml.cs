using Birne.Core;
using Birne.MobileApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Birne.MobileApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CartPage : ContentPage
    {
        public CartPage()
        {

            //Products = new ObservableCollection<Products>();
            //Products.Add(new Products());
            //Products.Add(new Products());
            //Products.Add(new Products());
            //Products.Add(new Products());
            //Products.Add(new Products());
            //Products.Add(new Products());

            InitializeComponent();

            //var viewModel = BindingContext as CartViewModel;

            //viewModel.Products = Products;


        }

        // TODO delete this
        //public ObservableCollection<Products> Products { get; set; }

    }
}