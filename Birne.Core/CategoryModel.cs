using System.ComponentModel;

namespace Birne.Core.Models
{
    public class CategoryModel : BaseModel
    {
        private string _name;
        public string Name
        {
            get => _name;
            set => RaiseAndSetIfChanged(ref _name, value);
        }

        private bool _isActive;
        public bool IsActive
        {
            get => _isActive;
            set => RaiseAndSetIfChanged(ref _isActive, value);
        }
    }
}
