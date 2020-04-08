using System;
using System.Collections.ObjectModel;
using System.Linq;
using Birne.Core.Models;
using Birne.MobileApp.Views;
using Bogus;
using Prism.Commands;
using Prism.Navigation;

namespace Birne.MobileApp.ViewModels
{
    public class HomeTabViewModel : BaseViewModel
    {
        #region Properties
        private ObservableCollection<CategoryModel> _categories;
        public ObservableCollection<CategoryModel> Categories
        {
            get => _categories;
            set => RaiseAndSetIfChanged(ref _categories, value);
        }

        private ObservableCollection<ProductModel> _products;
        public ObservableCollection<ProductModel> Products
        {
            get => _products;
            set => RaiseAndSetIfChanged(ref _products, value);
        }
        #endregion

        #region Commands
        public DelegateCommand<CategoryModel> SelectedCategoryCommand { get; private set; }

        public DelegateCommand<ProductModel> SelectedProductCommand { get; private set; }
        #endregion

        #region Private Methods
        public HomeTabViewModel(INavigationService navigationService) : base(navigationService)
        {
            SelectedCategoryCommand = new DelegateCommand<CategoryModel>(SelectedCategory);
            SelectedProductCommand = new DelegateCommand<ProductModel>(SelectedProduct);

            InitializeClass();
        }

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
        }

        private void SelectedProduct(ProductModel productModel)
        {
            NavigationParameters navParameters = new NavigationParameters();
            navParameters.Add(nameof(ProductModel), productModel);

            NavigationService.NavigateAsync(nameof(ProductDetailPage), navParameters);
        }

        private void InitializeClass()
        {
            Categories = new ObservableCollection<CategoryModel>()
            {
                new CategoryModel() { Name = "BASADO EN TUS GUSTOS", IsActive=true},
                new CategoryModel() { Name = "LIMPIEZA"},
                new CategoryModel() { Name = "FRUTAS Y VERDURAS"}
            };

            var productIds = 0;
            var productFake = new Faker<ProductModel>("es").StrictMode(true)
                .RuleFor(u => u.Id, f => productIds++)
                .RuleFor(u => u.Name, f => f.Commerce.Product())
                .RuleFor(u => u.Description, (f, u) => u.Name)
                .RuleFor(u => u.Price, f => f.Random.Number(100, 100000))
                .RuleFor(u => u.Category, f => _categories[f.Random.Number(0, 2)])
                .RuleFor(u => u.Unit, f => f.Commerce.ProductAdjective())
                .RuleFor(u => u.ImageURL, f => f.Image.PicsumUrl());

            Products = new ObservableCollection<ProductModel>(productFake.Generate(7));
        }

        private void SelectedCategory(CategoryModel category)
        {
            if (category.IsActive)
                return;

            var categoryPrevious = Categories.FirstOrDefault(x => x.IsActive);
            if (categoryPrevious != null)
                categoryPrevious.IsActive = false;

            category.IsActive = true;
        }
        #endregion
    }
}
