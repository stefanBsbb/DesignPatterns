using ShoppingCart.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Bridge
{
    public class CardPayment : Payment
    {
        public override void MakePayment()
        {
            _IPaymentSystem.ProcessPayment("Card Gateway");
        }
    }
}
