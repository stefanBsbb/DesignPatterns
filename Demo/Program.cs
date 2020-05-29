
using System;
using StatePat;
using ShoppingCart.Models;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using ShoppingCart.Interfaces;
using System.Xml.Serialization;
using ShoppingCart.State_Pattern;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Facade : Start");
            Console.WriteLine("************************************");
            Context context = new Context();
            context.Add = new Adding();
            context.Discard = new Discarding();
            Console.WriteLine("State:Adding products..");
            char command = ' ';
            string choice;
            string choiceD;
            int productID = 0;
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Please select a product! 'm' for milk,'b' for bread,'e' for eggs,'o' for oranges,'p' for pepsi");
                do
                    choice = Console.ReadLine();
                while (choice == null);
                command = choice[0];
                context.Request(command);
                switch (char.ToLower(command))
                {
                    case 'm': productID = 1; break;
                    case 'b': productID = 2; break;
                    case 'e': productID = 3; break;
                    case 'o': productID = 4; break;
                    case 'p': productID = 5; break;
                    default:
                        break;
                }
                context.cart.CheckProduct(productID);
            }

            Console.WriteLine("Do u wish to discard products? y/n");
            choiceD = Console.ReadLine();
            if (choiceD == "y")
            {
                for (int i = 0; i < 2; i++)
                {


                    Console.WriteLine("Please select a product to discard! 'm' for milk,'b' for bread,'e' for eggs,'o' for oranges,'p' for pepsi");
                    do
                        choice = Console.ReadLine();
                    while (choice == null);
                    command = choice[0];
                    context.DiscardRequest(command);

                }
            
            }
            else
            {
                Console.WriteLine("wrong key!, proceeding order");
            }
            int cartID = 1234;
            int userID = 1234;
            Console.WriteLine("************************************");
            int orderID = context.cart.PlaceOrder(cartID, userID);
            Console.WriteLine("************************************");

            Console.ReadLine();
        }

    }
}
