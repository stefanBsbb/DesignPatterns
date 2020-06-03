using ShoppingCart.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Abstractions
{
    public abstract class Payment
    {
        public IPaymentSystem _IPaymentSystem;
        public abstract void MakePayment();
    }
}
