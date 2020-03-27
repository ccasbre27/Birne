using System;

namespace Birne.Core{
    public class OrderItem : BaseModel
    {
        private int id;
        private int product_id;
        private int quantity;

        public int order_id
        {
            get => id;
            set => RaiseAndSetIfChanged(ref id, value);
        }

        public int prod_id
        {
            get => product_id;
            set => RaiseAndSetIfChanged(ref product_id, value);
        }

        public int product_quantity
        {
            get => quantity;
            set => RaiseAndSetIfChanged(ref quantity, value);
        }

    }
}