using System.Collections.ObjectModel;
using System.Linq;
using Birne.Core.Models;
using Prism.Commands;

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

        public DelegateCommand<CategoryModel> SelectedCategoryCommand { get; private set; }

        public HomeTabViewModel()
        {
            Categories = new ObservableCollection<CategoryModel>()
            {
                new CategoryModel() { Name = "BASADO EN TUS GUSTOS", IsActive=true},
                new CategoryModel() { Name = "LIMPIEZA"},
                new CategoryModel() { Name = "FRUTAS Y VERDURAS"}
            };
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
