using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale
{
    class POSapp
    {
        public POSapp()
        {
            while (newSale)
            {
                DisplayInventory();
                while (anotherProduct)
                {
                    AddToOrder();
                    DiplayOrder();
                    anotherProduct();
                }
                requestPaymentType();
                displayReceipt();
                newSale = true;
            }


            }
       

    }
}
