using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PointOfSale
{
    class Product
    {
        private string name;
        private string category;
        private string description;
        private float price;

        List<Product> products = new List<Product>();

        //private string storeinventory;

        public Product(string item, string category, string description, float price)
        {
            this.name = item;
            this.category = category;
            this.description = description;
            this.price = price;
        }

        public void outputProductList()
        {
            buildProduct();
            printProduct(products);
        }

        public List<Product> buildProduct()
        {
            Product a = new Product("Apple", "Produce", "Fruit", 1.00f);
            products.Add(a);
            Product b = new Product("Banana", "Produce", "Fruit", 0.50f);
            products.Add(b);
            Product c = new Product("Cherry", "Produce", "Fruit", 1.50f);
            products.Add(c);

            return products;
        }

        public void printProduct(List<Product> products)
        {
            Console.WriteLine("#\tNAME\t\tCATEGORY\tDESC.\t\tPRICE\n");

            for (int i = 0; i < products.Count(); i++)
            {
                string currentItem = products[i].getName();
                string currentCategory = products[i].getCategory();
                string currentDescription = products[i].getDescription();
                float currentPrice = products[i].getPrice();
                Console.WriteLine(i + ")\t" + currentItem + "\t\t" + currentCategory + "\t\t" + currentDescription + "\t\t$ " + currentPrice.ToString("0.00"));
            }
            Console.WriteLine();
        }

        public string getName()
        {
            return name;
        }

        public string getCategory()
        {
            return category;
        }

        public string getDescription()
        {
            return description;
        }

        public float getPrice()
        {
            return price;
        }


        //public string readInventory()
        //{
        //    return storeinventory;

        //}

        //public CustomerOrder()
        //{

        //}

        //public readCustomerOrder()
        //{

        //}

        //public addToCustomerOrder()
        //{

        //}
    }
}
