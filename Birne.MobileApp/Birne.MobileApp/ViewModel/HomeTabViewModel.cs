using System;
using System.Collections.ObjectModel;
using System.Linq;
using Birne.MobileApp.Model;
using Prism.Commands;

namespace Birne.MobileApp.ViewModel
{
    public class HomeTabViewModel : BaseViewModel
    {
        public ObservableCollection<CategoryModel> Categories => new ObservableCollection<CategoryModel>()
        {
            new CategoryModel() { Name = "BASADO EN TUS GASTOS", IsActive=true},
            new CategoryModel() { Name = "LIMPIEZA"},
            new CategoryModel() { Name = "FRUTAS Y VERDURAS"}
        };

        public DelegateCommand<CategoryModel> SelectedCategoryCommand { get; private set; }

        public HomeTabViewModel()
        {
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
