using System;

namespace Birne.Core.Models
{
    public class ProductModel : BaseModel
    {
        private int _id;
        private string _name;
        private string _description;
        private decimal _price; // price is set by merchant
        private string _imageURL;
        private CategoryModel _category;
        private string _unit;
        //private int _quantity; //TODO delete, used by the moment in cart page 

        public int Id
        {
            get => _id;
            set => RaiseAndSetIfChanged(ref _id, value);
        }

        public string Name
        {
            get => _name;
            set => RaiseAndSetIfChanged(ref _name, value);
        }

        public string Description
        {
            get => _description;
            set => RaiseAndSetIfChanged(ref _description, value);
        }

        public decimal Price
        {
            get => _price;
            set => RaiseAndSetIfChanged(ref _price, value);
        }

        public string ImageURL
        {
            get => _imageURL;
            set => RaiseAndSetIfChanged(ref _imageURL, value);
        }

        public CategoryModel Category
        {
            get => _category;
            set => RaiseAndSetIfChanged(ref _category, value);
        }

        public string Unit
        {
            get => _unit;
            set => RaiseAndSetIfChanged(ref _unit, value);
        }
        //TODO delete, used by the moment in cart page 
        //public int Quantity
        //{
        //    get => _quantity;
        //    set => RaiseAndSetIfChanged(ref _quantity, value);
        //}
    }
}