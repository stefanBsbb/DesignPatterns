using ShoppingCart.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Bridge
{
    public class NetBankingPayment : Payment
    {
        public override void MakePayment()
        {
            _IPaymentSystem.ProcessPayment("NetBanking Gateway");
        }
    }
}
