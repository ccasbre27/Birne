using System;

namespace Birne.Core{
    public class Product : BaseModel{
        public int id;
        public string name;
        public string merchant_id;
        public int price; // price is set by merchant
        public string status; //in or out of stock
        public string img_url;

       public int product_id
        {
            get => id;
            set => RaiseAndSetIfChanged(ref id, value);
        }

        public string product_name
        {
            get => name;
            set => RaiseAndSetIfChanged(ref name, value);
        }

        public string merch_id
        {
            get => merchant_id;
            set => RaiseAndSetIfChanged(ref merchant_id, value);
        }

        public int product_price
        {
            get => price;
            set => RaiseAndSetIfChanged(ref price, value);
        }

        public string product_status
        {
            get => status;
            set => RaiseAndSetIfChanged(ref status, value);
        }
        public string image_url
        {
            get => img_url;
            set => RaiseAndSetIfChanged(ref img_url, value);
        }        

    }
}