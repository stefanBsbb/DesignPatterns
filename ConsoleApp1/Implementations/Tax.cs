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
                case 'a':result = 0.5;break;
                case 'b':result = 1;break;
                case 'c':result = 1.5;break;
                case 'd':result = 3.0;break;
                default:;result = 1; break;
            }
            return result;
        }
    }
}
