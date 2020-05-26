using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart.Models;
namespace ShoppingCart.Abstractions
{
    public  abstract class BaseCart
    {
        public virtual List<Product> _Cart { get; set; }


    }
}
