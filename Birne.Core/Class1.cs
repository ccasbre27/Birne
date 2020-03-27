using System;
using System.Collections.Generic;

namespace Birne.Core.Models
{
    public class Class1
    {
        public Class1()
        {
            List<Product> product_list = new List<Product>();
            product_list.Add(new Product() { id = 1, name = "aguacate", merchant_id = "1", price = 1000, status = "in stock", img_url = "aguacate.png" });
            product_list.Add(new Product() { id = 2, name = "apple", merchant_id = "2", price = 1000, status = "in stock", img_url = "apple.png" });
            product_list.Add(new Product() { id = 3, name = "banano", merchant_id = "3", price = 1000, status = "in stock", img_url = "banano.png" });
            product_list.Add(new Product() { id = 4, name = "carne", merchant_id = "4", price = 1000, status = "in stock", img_url = "carne.png" });
            product_list.Add(new Product() { id = 5, name = "cebolla", merchant_id = "5", price = 1000, status = "in stock", img_url = "cebolla.png" });
            product_list.Add(new Product() { id = 6, name = "cloro", merchant_id = "6", price = 1000, status = "in stock", img_url = "cloro.png" });
            product_list.Add(new Product() { id = 7, name = "desinfectante", merchant_id = "7", price = 1000, status = "in stock", img_url = "desinfectante.png" });
            product_list.Add(new Product() { id = 8, name = "jabon", merchant_id = "8", price = 1000, status = "in stock", img_url = "jabon.png" });
            product_list.Add(new Product() { id = 9, name = "jalea", merchant_id = "9", price = 1000, status = "in stock", img_url = "jalea.png" });
            product_list.Add(new Product() { id = 10, name = "jugo", merchant_id = "10", price = 1000, status = "in stock", img_url = "jugo.png" });
            product_list.Add(new Product() { id = 11, name = "lechuga", merchant_id = "11", price = 1000, status = "in stock", img_url = "lechuga.png" });
            product_list.Add(new Product() { id = 12, name = "manzana", merchant_id = "12", price = 1000, status = "in stock", img_url = "manzana.png" });
            product_list.Add(new Product() { id = 13, name = "pina", merchant_id = "13", price = 1000, status = "in stock", img_url = "pineapple.png" });
            product_list.Add(new Product() { id = 14, name = "platano_verde", merchant_id = "14", price = 1000, status = "in stock", img_url = "platano_verde.png" });
            product_list.Add(new Product() { id = 15, name = "pollo", merchant_id = "15", price = 1000, status = "in stock", img_url = "pollo.png" });
            product_list.Add(new Product() { id = 16, name = "zanahoria", merchant_id = "16", price = 1000, status = "in stock", img_url = "zanahoria.png" });


            List<Product> product_quantity = new List<Product>();
            product_quantity.Add(new Product() { id = 1, name = "aguacate", merchant_id = "1", price = 1000, status = "in stock", img_url = "aguacate.png", quantity = 2 });
            product_quantity.Add(new Product() { id = 1, name = "manzana", merchant_id = "1", price = 1000, status = "out of stock", img_url = "manzana.png", quantity = 0 });
            product_quantity.Add(new Product() { id = 1, name = "carne", merchant_id = "1", price = 1000, status = "in stock", img_url = "carne.png", quantity = 5 });
            product_quantity.Add(new Product() { id = 1, name = "pollo", merchant_id = "1", price = 1000, status = "in stock", img_url = "pollo.png", quantity = 6 });
            product_quantity.Add(new Product() { id = 1, name = "cloro", merchant_id = "1", price = 1000, status = "in stock", img_url = "cloro.png", quantity = 3 });

        }
    }
}
