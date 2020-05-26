using ShoppingCart.Models;
using ShoppingCart.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatePat
{
    public class Context
    {
        public Cart cart = new Cart();
        public AddAb Add { get; set; }
        public void Request(char c)

        { 
            string result;
            switch (char.ToLower(c))
            {
                case 'm': result = Add.AddMilk(this,cart);
                    
                    break;
                case 'b': result = Add.AddBread(this,cart);

                    break;
                case 'e': result = Add.AddEggs(this,cart);

                    break;
                case 'o': result = Add.AddOranges(this,cart);

                    break;
                case 'p': result = Add.AddPepsi(this,cart);

                    break;
                default:result = "Try again";
                    break;
            }
            Console.WriteLine(result);
        }
        

    }
}
