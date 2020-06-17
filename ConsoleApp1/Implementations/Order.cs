using ShoppingCart.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Implementations
{
    public class Order : IOrder
    {
        public int PlaceOrderDetails(int cartID, int shippingAddressID)
        {
            Console.WriteLine("\t  Order: PlaceOrderDetails");
            return 10;
        }
    }
}
