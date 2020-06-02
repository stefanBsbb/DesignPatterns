using ShoppingCart.Implementations;
using StatePat;
using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart;
using ShoppingCart.State_Pattern;

namespace Demo
{
    public class Init
    {
        private Context context = new Context();
        private char command = ' ';
        public void AddProdToCart()
        {
            Console.WriteLine("Facade : Start");
            Console.WriteLine("************************************");
            context.Add = new Adding();
            string choice = "";
            //int productID = 0;
            while (choice != "f")
            {
                Console.WriteLine("Please select a product! 'm' for milk,'b' for bread,'e' for eggs,'o' for oranges,'p' for pepsi");
                Console.WriteLine("Press ESC to stop");
                choice = ReadLineWithCancel();
                if (choice == "" || choice.Length > 1)
                {
                    Console.WriteLine("   Invalid input!");
                }
                else
                {
                    if (choice != null && choice != "" && choice.Length == 1)
                    {
                        command = choice[0];
                        context.AddRequest(command);
                        if (Enum.TryParse(char.ToLower(command).ToString(), out Input result))
                        {
                            context.cart.CheckProduct((int)result);
                        }
                    }
                }
            }
        }
        public void DiscardProdFromCart()
        {
            string choiceD = "";
            string choiceDD = "";
            context.Discard = new Discarding();
            Console.WriteLine("Do u wish to discard products? y/n");
            choiceD = Console.ReadLine();
            if (choiceD == "y")
            {
                while (choiceDD != "f")
                {
                    Console.WriteLine("Please select a product to discard! 'm' for milk,'b' for bread,'e' for eggs,'o' for oranges,'p' for pepsi");
                    Console.WriteLine("Press ESC to stop");
                    choiceDD = ReadLineWithCancel();
                    if (choiceDD == "")
                    {
                        Console.WriteLine("Input cant be null");
                    }
                    if (choiceDD != null && choiceDD != "")
                    {
                        command = choiceDD[0];
                        context.DiscardRequest(command);
                    }
                }
            }
            if (choiceD == "n")
            {
                Console.WriteLine("Proceeding to orderdetails..");
            }
            else
            {
                Console.WriteLine("wrong key");
            }
        }
        private string ReadLineWithCancel()
        {
            string result = "f";
            StringBuilder buffer = new StringBuilder();
            ConsoleKeyInfo info = Console.ReadKey(true);
            while (info.Key != ConsoleKey.Enter && info.Key != ConsoleKey.Escape)
            {
                Console.Write(info.KeyChar);
                buffer.Append(info.KeyChar);
                info = Console.ReadKey(true);
            }

            if (info.Key == ConsoleKey.Enter)
            {
                result = buffer.ToString();
            }
            return result;
        }
        public void PlaceOrder()
        {
            Random rand = new Random();
            int cartID;
            int userID;
            cartID = rand.Next(1, 2000);
            userID = rand.Next(1, 2000);
            Console.WriteLine("************************************");
            int orderID = context.cart.PlaceOrder(cartID, userID);
            Console.WriteLine("************************************");
            Console.ReadLine();
        }

    }

}
