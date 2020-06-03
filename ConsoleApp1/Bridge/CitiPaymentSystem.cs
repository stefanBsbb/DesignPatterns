using System;
using System.Collections.Generic;
using System.Text;

using ShoppingCart.Interfaces;

namespace ShoppingCart.Bridge
{
    public class CitiPaymentSystem : IPaymentSystem
    {
        public void ProcessPayment(string paymentSystem)
        {
            Console.WriteLine("Using CitiBank payment for  " + paymentSystem);
        }
    }
}
