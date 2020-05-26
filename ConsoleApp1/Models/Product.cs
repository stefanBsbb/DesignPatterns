using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Models
{
    public class Product
    {
        public int ProductID{ get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }



        public Product(int id, string n,  double c)
        {
            this.ProductID = id;
            this.Name = n;
            this.Cost = c;

        }
    }
}

