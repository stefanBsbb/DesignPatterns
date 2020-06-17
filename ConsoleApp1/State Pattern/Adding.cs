using ShoppingCart.Models;

using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart.Abstractions;
using ShoppingCart.Implementations;

namespace StatePat
{
    public class Adding : AddAb
    {

        public override string AddMilk(Context context,Cart cart)
        {
            cart.AddItemToCart(new Product(1,"milk",5));
            return "\nAdding milk to the cart...";
        }
        public override string AddBread(Context context, Cart cart)
        {
            cart.AddItemToCart(new Product(2, "bread", 2));
            return "\nAdding bread to the cart...";
        }
        public override string AddEggs(Context context, Cart cart)
        {
            cart.AddItemToCart(new Product(3, "eggs", 3));
            return "\nAdding eggs to the cart...";
        }
        public override string AddOranges(Context context, Cart cart)
        {
            cart.AddItemToCart(new Product(4, "oranges", 6));
            return "\nAdding oranges to the cart...";
        }
        public override string AddPepsi(Context context, Cart cart)
        {
            cart.AddItemToCart(new Product(5, "pepsi", 4));
            return "\nAdding pepsi to the cart...";
        }
    }
}
