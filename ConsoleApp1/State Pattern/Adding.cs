using ShoppingCart.Models;

using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart.Abstractions;
namespace StatePat
{
    public class Adding : AddAb
    {

        public override string AddMilk(Context context,Cart cart)
        {
            cart.AddItemToCart(new Product(1,"milk",5));
            return "Adding milk to the cart !";
        }
        public override string AddBread(Context context, Cart cart)
        {
            cart.AddItemToCart(new Product(2, "bread", 5));
            return "Adding bread to the cart !";
        }
        public override string AddEggs(Context context, Cart cart)
        {
            cart.AddItemToCart(new Product(3, "eggs", 5));
            return "Adding eggs to the cart !";
        }
        public override string AddOranges(Context context, Cart cart)
        {
            cart.AddItemToCart(new Product(4, "oranges", 5));
            return "Adding oranges to the cart !";
        }
        public override string AddPepsi(Context context, Cart cart)
        {
            cart.AddItemToCart(new Product(5, "pepsi", 5));
            return "Adding pepsi to the cart !";
        }
    }
}
