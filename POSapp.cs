using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale
{
    class POSapp
    {
        //public string item;
        //public string category;
        //public string description;
        //public float price;

        public POSapp()
        {
            Console.WriteLine("\t\tConvenient Store Point-Of-Sale Software\n\n");

            Product p = new Product("test","test","test",18.00f);

            p.outputProductList();

            //while (newSale)
            //{
            //    DisplayInventory();
            //    while (anotherProduct)
            //    {
            //        AddToOrder();
            //        DiplayOrder();
            //        anotherProduct();
            //    }
            //    requestPaymentType();
            //    displayReceipt();
            //    newSale = true;
            //}


        }
       

    }
}
