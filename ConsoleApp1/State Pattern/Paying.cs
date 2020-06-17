using ShoppingCart.Abstractions;
using ShoppingCart.Bridge;
using StatePat;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.State_Pattern
{
    public class Paying : PaymentAb
    {
        public override string Card(Context context)
        {
            Payment order = new CardPayment();
            return "Selecting card gateway...\n";
        }

        public override string NetBanking(Context context)
        {
            Payment order2 = new NetBankingPayment();
            return "Selecting netbanking gateway...\n";
        }
        public override string CardCITI(Context context)
        {
            Payment order = new CardPayment();
            order._IPaymentSystem = new CitiPaymentSystem();
            order.MakePayment();
            return "";
        }
        public override string CardIDBI(Context context)
        {
            Payment order = new CardPayment();
            order._IPaymentSystem = new CitiPaymentSystem();
            order.MakePayment();
            return "";
        }
        public override string NetIDBI(Context context)
        {
            Payment order = new NetBankingPayment();
            order._IPaymentSystem = new IDBIPaymentSystem();
            order.MakePayment();
            return "";
        }
        public override string NetCITI(Context context)
        {
            Payment order = new NetBankingPayment();
            order._IPaymentSystem = new CitiPaymentSystem();
            order.MakePayment();
            return "";
        }
    }
}
