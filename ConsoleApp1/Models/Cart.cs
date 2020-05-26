﻿using ShoppingCart.Abstractions;
using ShoppingCart.Implementations;
using ShoppingCart.Interfaces;
using StatePat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart.Models
{
    public class Cart :BaseCart,ICart
    {


        public int CartID { get; set; }
        public int UserID { get; set; }

        public override List<Product> _Cart { get; set; } = new List<Product>();

        public string AddItemToCart(Product product)
        {
            this._Cart.Add(product);
            if (product == null)
            {
                return "Failed to add product to cart";
            }
            return "Product has been succesfully added";
        }
        public string DiscardItemFromCart(Product product)
        {
            this._Cart.Remove(product);
            if (product == null)
            {
                return "Failed to add product to cart";
            }
            return "Product has been succesfully added";
        }
        public bool CheckItemAvailability(string product)
        {
            if (product != null)
            {
                return true;
            }
            return false;

        }

        public double GetCartPrice(int cartID)
        {
            
            var ProductsCost = this._Cart.Sum(i => i.Cost);
            Console.WriteLine("\t  Total price :" + ProductsCost);
            return ProductsCost; 

        }
        public void ApplyTax(int cartID, double taxPercent)
        {
            double cartPrice = this._Cart.Sum(i => i.Cost);
            double taxTotal = cartPrice + cartPrice / taxPercent;
            Console.WriteLine("Total money with tax:"+ taxTotal); 
        }
        public string GetItemDetails(int id)
        {

            var rawProduct = this._Cart.FirstOrDefault(i => i.ProductID == id);
            if (rawProduct == null)
            { return "Product not found"; }
            return $"Product: {rawProduct.Name} - {rawProduct.Cost}";
        }
        public bool LockItemInStock(int productID)
        {
            Console.WriteLine("Locking item");
            return true;
        }
        //FACADE--------
        public int CheckProduct(int productID)
        {
            Console.WriteLine("Checking product...");
            int cartID = 0;
            //Step 1 : GetItem
            string product = GetItemDetails(productID);
            //Step 2 : Check Availability
            if (CheckItemAvailability(product))
            {
                //Step 3 : Lock Item in the Stock
                LockItemInStock(productID);
            }
            Console.WriteLine("Check has ended");
            return cartID;
        }

        public int PlaceOrder(int cartID, int userID)
        {
            Console.WriteLine("Start PlaceOrderDetails");
            int orderID = -1;
            IWallet wallet = new Wallet();
            ITax tax = new Tax();
            IAddress address = new AddressDetails();
            IOrder order = new Order();
            //Step 1 : Get Tax percentage by State
            Console.WriteLine("Please select a state , options : a,b,c,d");
            char state =Convert.ToChar(Console.ReadLine());
            double stateTax = tax.GetTaxByState(state);     
            //Step 2 : Get user Wallet balance
            double userWalletBalance = wallet.GetUserBalance(userID);
            //Step 3 : Get the cart items price
            double cartPrice = GetCartPrice(cartID);
            //Step 4 : Apply Tax on the Cart Items
            ApplyTax(cartID, stateTax);
            //Step 5 : Compare the balance and price
            if (userWalletBalance > cartPrice)
            {
                //Step 6 : Get user Address and set to cart
                Address userAddress = address.GetAddressDetails(userID);
                //Step 7 : Place the order
                orderID = order.PlaceOrderDetails(cartID, userAddress.AddressID);

            }
            Console.WriteLine("End PlaceOrderDetails");
            return orderID;
        }
    }
}