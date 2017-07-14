using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PointOfSale
{
    class Products
    {
        private String item;
        private String category;
        private String description;
        private float price;
        private string storeinventory;
        public Products()//(string item, string category, string description, float price)
        {
            this.item = item;    
            this.category = category;
            this.description = description;
            this.price = price;
        }

        public void PList(string item, string category, string description, float price)
        {
            List<Products> storeinventory = new List<Products>();
            Products a = new Products("apple", "produce", "fruit", 1.00f);
            storeinventory.Add(a);
            Products b = new Products("banana", "produce", "fruit", 1.00f);
            storeinventory.Add(a);
        }

        public string readInventory()
        {
            return storeinventory;

        }
         
        public CustomerOrder()
        {

        }

        public readCustomerOrder()
        {

        }

        public addToCustomerOrder()
        {

        }

}
