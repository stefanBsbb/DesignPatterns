using ShoppingCart.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Implementations
{
    public class Wallet : IWallet
    {
        public double GetUserBalance(int userID)
        {
            Random rand = new Random();            
            double balance = rand.Next(1,500);
            Console.WriteLine("\t  Wallet: " + balance);
            return balance;
        }
    }
}
