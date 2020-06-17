using ShoppingCart.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart.Models;
namespace ShoppingCart.Implementations
{
    public class Tax : ITax
    {

        public double GetTaxByState(char state)
        {
            double result = 0;
            switch (char.ToLower(state))
            {
                case 'a':result = 5; break;
                case 'b':result = 10; break;
                case 'c':result = 15; break;
                case 'd':result = 30; break;
                default:result = 10; break;
            }
            return result;
        }
    }
}
