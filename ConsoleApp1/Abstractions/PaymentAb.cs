using StatePat;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Abstractions
{
    public abstract class PaymentAb
    {
        public virtual string Card(Context context) { return ""; }
        public virtual string NetBanking(Context context) { return ""; }
        public virtual string CardIDBI(Context context) { return ""; }
        public virtual string CardCITI(Context context) { return ""; }
        public virtual string NetIDBI(Context context) { return ""; }
        public virtual string NetCITI(Context context) { return ""; }


    }
}
