using System;
using System.Collections.Generic;

namespace DEV_10
{
    /// <summary>
    /// Contains information of product
    /// </summary>
    public struct Product
    {
        int productID;
        string productName;
        int quantity;
        public Product(int ID, string Name, int Quantity)
        {
            productID = ID;
            productName = Name;
            quantity = Quantity;
        }
    }

    /// <summary>
    /// Contains Shopping Cart information
    /// </summary>
    class ShoppingCart
    {
        private int orderID;
        private string shopperName;
        private string shopperEmail;
        private bool orderCompleted;
        private List<Product> contents =  new List<Product>();

        public ShoppingCart(int orderID, string shopperName, string shopperEmail,List<Product> list, bool oderCompleted)
        {
            this.orderID = orderID;
            this.shopperName = shopperName;
            this.shopperEmail = shopperName;
            this.contents = list;
            this.orderCompleted = oderCompleted;
            Console.WriteLine("Shopping card is Created");
        }
    }
}
