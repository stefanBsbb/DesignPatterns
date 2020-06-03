using ShoppingCart.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Bridge
{
    public class IDBIPaymentSystem : IPaymentSystem
    {
        public void ProcessPayment(string paymentSystem)
        {
            Console.WriteLine("Using IDBIBank payment for  " + paymentSystem);
        }
    }
}
