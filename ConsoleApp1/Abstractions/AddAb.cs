using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Text;
using StatePat;
namespace ShoppingCart.Abstractions
{
    public abstract class AddAb
    {
        public virtual string AddMilk(Context context,Cart cart) { return ""; }
        public virtual string AddBread(Context context,Cart cart) { return ""; }
        public virtual string AddPepsi(Context context, Cart cart) { return ""; }
        public virtual string AddEggs(Context context, Cart cart) { return ""; }
        public virtual string AddOranges(Context context, Cart cart) { return ""; }
        

    }
}
