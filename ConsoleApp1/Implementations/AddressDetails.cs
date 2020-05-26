using ShoppingCart.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Implementations
{
    public class AddressDetails : IAddress
    {
        public Models.Address GetAddressDetails(int userID)
        {
            Console.WriteLine("\t  Address : GetAddressDetails");
            return new Models.Address();
        }
    }
}
