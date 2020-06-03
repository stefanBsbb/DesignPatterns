using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Interfaces
{
    public interface IPaymentSystem
    {
        void ProcessPayment(string paymentSystem);
    }
}
