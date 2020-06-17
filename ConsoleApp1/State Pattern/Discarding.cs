using ShoppingCart.Models;

using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart.Abstractions;
using StatePat;
using System.Linq;
using ShoppingCart.Implementations;

namespace ShoppingCart.State_Pattern
{
    public class Discarding : DiscardAb
    {
        
        public override string DiscardMilk(Context context, Cart cart)
        {
            
            var rawProduct = cart._Cart.FirstOrDefault(i => i.ProductID == 1);
            if (rawProduct==null)
            {                
                return "\nThat product isn't in the cart!\n";                
            }
            cart.DiscardItemFromCart(1);
            return "\nRemoving milk from the cart!\n";
        }
        public override string DiscardBread(Context context, Cart cart)
        {
            var rawProduct = cart._Cart.FirstOrDefault(i => i.ProductID == 2);
            if (rawProduct == null)
            {
                return "\nThat product isn't in the cart!\n";
            }
            cart.DiscardItemFromCart(2);
            return "\nRemoving bread from the cart!\n";
        }
        public override string DiscardEggs(Context context, Cart cart)
        {
            var rawProduct = cart._Cart.FirstOrDefault(i => i.ProductID == 3);
            if (rawProduct == null)
            {
                return "\nThat product isn't in the cart!\n";
            }
            cart.DiscardItemFromCart(3);
            return "\nRemoving eggs from the cart!\n";
        }
        public override string DiscardOranges(Context context, Cart cart)
        {
            var rawProduct = cart._Cart.FirstOrDefault(i => i.ProductID == 4);
            if (rawProduct == null)
            {
                return "\nThat product isn't in the cart!\n";
            }
            cart.DiscardItemFromCart(4);
            return "\nRemoving oranges from the cart!\n";
        }
        public override string DiscardPepsi(Context context, Cart cart)
        {
            var rawProduct = cart._Cart.FirstOrDefault(i => i.ProductID == 5);
            if (rawProduct == null)
            {
                return "\nThat product isn't in the cart!\n";
            }
            cart.DiscardItemFromCart(5);
            return "\nRemoving pepsi from the cart!\n";
        }
    }
}
