
using System;
using StatePat;
using ShoppingCart.Models;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using ShoppingCart.Interfaces;
using System.Xml.Serialization;
using ShoppingCart.State_Pattern;
using System.Text;
namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Init newInit = new Init();
            newInit.AddProdToCart();
            newInit.DiscardProdFromCart();
            newInit.PlaceOrder();
        }
    }
}
