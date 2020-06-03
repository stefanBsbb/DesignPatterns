using ShoppingCart.Implementations;
using StatePat;
using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart;
using ShoppingCart.State_Pattern;
using ShoppingCart.Abstractions;

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
            while (choiceD.Length != 1)
            {
                Console.WriteLine("Do u wish to discard products? y/n");
                choiceD = Console.ReadLine();
                if (choiceD == "y" || choiceD == "n") { }

                else
                {
                    Console.WriteLine("   Try again !");
                    choiceD = "";
                }
            }

            if (choiceD == "y")
            {
                while (choiceDD != "f")
                {
                    Console.WriteLine("Please select a product to discard! 'm' for milk,'b' for bread,'e' for eggs,'o' for oranges,'p' for pepsi");
                    Console.WriteLine("Press ESC to stop");
                    choiceDD = ReadLineWithCancel();
                    if (choiceDD == "" || choiceDD.Length > 1)
                    {
                        Console.WriteLine("   Invalid input!");
                    }
                    else
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
        public string PaymentChoice = "";
        public string PaymentGateway()
        {
            //string PaymentChoice = "";
            context.Payment = new Paying();
            while (PaymentChoice.Length != 1)
            {
                Console.WriteLine("Please select a payment gateway! 'c' for card,'n' for netbanking");
                PaymentChoice = Console.ReadLine();
                if (PaymentChoice == "" || PaymentChoice.Length > 1)
                {
                    Console.WriteLine("   Invalid input!");
                }
                else if (PaymentChoice == "c" || PaymentChoice == "n")
                {
                    command = PaymentChoice[0];
                    context.PaymentGatewayRequest(command);
                }
                else
                { PaymentChoice = ""; }
            }
            return PaymentChoice;
        }
        public void PaymentMethodC()
        {
            string choice = "";
            context.Payment = new Paying();
            while (choice.Length != 1)
            {
                Console.WriteLine("Please select a payment method! 'c' for citi payment system ,'i' for idbi payment system");
                choice = Console.ReadLine();
                if (choice == "" || choice.Length > 1)
                {
                    Console.WriteLine("   Invalid input!");
                }
                else if (choice == "c" || choice == "i")
                {
                    command = choice[0];
                    context.PaymentMethodRequestCard(command);
                }
                else
                { choice = ""; }
            }
        }
        public void PaymentMethodN()
        {
            string choice = "";
            context.Payment = new Paying();
            while (choice.Length != 1)
            {
                Console.WriteLine("Please select a payment method! 'c' for citi payment system ,'i' for idbi payment system");
                choice = Console.ReadLine();
                if (choice == "" || choice.Length > 1)
                {
                    Console.WriteLine("   Invalid input!");
                }
                else if (choice == "c" || choice == "i")
                {
                    command = choice[0];
                    context.PaymentMethodRequestNet(command);
                }
                else
                { choice = ""; }
            }
        }
        public void Payment()
        {
            PaymentGateway();

            if (PaymentChoice == "c")
            {
                PaymentMethodC();
            }
            if (PaymentChoice == "n")
            {
                PaymentMethodN();
            }
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
