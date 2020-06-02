using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart.Implementations;
using ShoppingCart.Models;
using StatePat;
namespace ShoppingCart.Abstractions
{
    public abstract class DiscardAb
    {
        public virtual string DiscardMilk(Context context, Cart cart) { return ""; }
        public virtual string DiscardBread(Context context, Cart cart) { return ""; }
        public virtual string DiscardPepsi(Context context, Cart cart) { return ""; }
        public virtual string DiscardEggs(Context context, Cart cart) { return ""; }
        public virtual string DiscardOranges(Context context, Cart cart) { return ""; }

    }
}
