using System.Collections.ObjectModel;
using System.Linq;
using Birne.Core.Models;
using Bogus;
using Prism.Commands;
using Prism.Navigation;

namespace Birne.MobileApp.ViewModels
{
    public class HomeTabViewModel : BaseViewModel
    {
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

        public DelegateCommand<CategoryModel> SelectedCategoryCommand { get; private set; }

        public HomeTabViewModel(INavigationService navigationService) : base(navigationService)
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

            SelectedCategoryCommand = new DelegateCommand<CategoryModel>(SelectedCategory);
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
    }
}
