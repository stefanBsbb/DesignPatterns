using ShoppingCart.Models;

using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart.Abstractions;
using StatePat;

namespace ShoppingCart.State_Pattern
{
    public class Discarding : DiscardAb
    {
        //public override string DiscardMilk(Context context, Cart cart)
        //{
        //    cart.DiscardItemFromCart(new Product(1, "milk", 5));
        //    return "Adding milk to the cart !";
        //}
        //public override string DiscardBread(Context context, Cart cart)
        //{
        //    cart.DiscardItemFromCart(new Product(2, "bread", 5));
        //    return "Adding bread to the cart !";
        //}
        //public override string DiscardEggs(Context context, Cart cart)
        //{
        //    cart.DiscardItemFromCart(new Product(3, "eggs", 5));
        //    return "Adding eggs to the cart !";
        //}
        //public override string DiscardOranges(Context context, Cart cart)
        //{
        //    cart.DiscardItemFromCart(new Product(4, "oranges", 5));
        //    return "Adding oranges to the cart !";
        //}
        //public override string DiscardPepsi(Context context, Cart cart)
        //{
        //    cart.DiscardItemFromCart(new Product(5, "pepsi", 5));
        //    return "Adding pepsi to the cart !";
        //}
    }
}
