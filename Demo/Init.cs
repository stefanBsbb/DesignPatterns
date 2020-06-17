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
                Console.WriteLine("\nPlease select a product!\n'm' for milk,\n'b' for bread,\n'e' for eggs,\n'o' for oranges,\n'p' for pepsi");
                Console.WriteLine("Press ESC to stop");
                choice = ReadLineWithCancel();
                Console.WriteLine();
                if (choice == "" || choice.Length > 1)
                {
                    Console.WriteLine("\nInvalid input!");
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
                Console.WriteLine("\nAll products selected:");
                context.PrintCart();
                Console.WriteLine();
                Console.WriteLine("Do u wish to discard products? y/n");
                choiceD = Console.ReadLine();
                Console.WriteLine();
                if (choiceD == "y" || choiceD == "n") { }

                else
                {
                    Console.WriteLine("\nTry again!");
                    choiceD = "";
                }
            }

            if (choiceD == "y")
            {
                while (choiceDD != "f")
                {
                    Console.WriteLine("Please select a product to discard!\n'm' for milk,\n'b' for bread,\n'e' for eggs,\n'o' for oranges,\n'p' for pepsi");
                    Console.WriteLine("Press ESC to stop");
                    choiceDD = ReadLineWithCancel();
                    Console.WriteLine();
                    if (choiceDD == "" || choiceDD.Length > 1)
                    {
                        Console.WriteLine("\nInvalid input!");
                    }
                    else
                    if (choiceDD != null && choiceDD != "")
                    {
                        command = choiceDD[0];
                        context.DiscardRequest(command);
                    }
                    Console.WriteLine("Your products:");
                    context.PrintCart();
                    Console.WriteLine();
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
                Console.WriteLine("Please select a payment gateway!\n'c' for card,\n'n' for netbanking");
                PaymentChoice = Console.ReadLine();
                Console.WriteLine();
                if (PaymentChoice == "" || PaymentChoice.Length > 1)
                {
                    Console.WriteLine("\nInvalid input!");
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
                Console.WriteLine("Please select a payment method!\n'c' for citi payment system ,\n'i' for idbi payment system");
                choice = Console.ReadLine();
                Console.WriteLine();
                if (choice == "" || choice.Length > 1)
                {
                    Console.WriteLine("\nInvalid input!");
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
                Console.WriteLine("Please select a payment method!\n'c' for citi payment system ,\n'i' for idbi payment system");
                choice = Console.ReadLine();
                Console.WriteLine();
                if (choice == "" || choice.Length > 1)
                {
                    Console.WriteLine("\nInvalid input!");
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
