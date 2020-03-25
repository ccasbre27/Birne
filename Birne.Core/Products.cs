using System;

namespace Birne.Core{
    public class Products{
        private int id;
        private string name;
        private int merchantId;
        private int price; // price is set by merchant
        private string status;

        public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public int getMerchantId()
        {
            return this.merchantId;
        }

        public void setMerchantId(int merchantId)
        {
            this.merchantId = merchantId;
        }

        public int getPrice()
        {
            return this.price;
        }

        public void setPrice(int price)
        {
            this.price = price;
        }

        public string getStatus()
        {
            return this.status;
        }

        public void setStatus(string status)
        {
            this.status = status;
        }

    }
}