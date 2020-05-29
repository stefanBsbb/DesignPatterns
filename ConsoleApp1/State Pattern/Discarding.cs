using ShoppingCart.Models;

using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart.Abstractions;
using StatePat;
using System.Linq;

namespace ShoppingCart.State_Pattern
{
    public class Discarding : DiscardAb
    {
        public override string DiscardMilk(Context context, Cart cart)
        {
            cart.DiscardItemFromCart(1);
            return "Removing milk from the cart!";
        }
        public override string DiscardBread(Context context, Cart cart)
        {
            cart.DiscardItemFromCart(2);
            return "Removing bread from the cart!";
        }
        public override string DiscardEggs(Context context, Cart cart)
        {
            cart.DiscardItemFromCart(3);
            return "Removing eggs from the cart!";
        }
        public override string DiscardOranges(Context context, Cart cart)
        {
            cart.DiscardItemFromCart(4);
            return "Removing oranges from the cart!";
        }
        public override string DiscardPepsi(Context context, Cart cart)
        {
            cart.DiscardItemFromCart(5);
            return "Removing pepsi from the cart!";
        }
    }
}
