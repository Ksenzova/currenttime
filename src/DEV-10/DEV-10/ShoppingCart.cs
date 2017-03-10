using System;
using System.Collections.Generic;

namespace DEV_10
{
    /// <summary>
    /// Contains information of product
    /// </summary>
    public struct Product
    {
        public int ProductID { get;}
        public string ProductName { get;}
        public int Quantity { get; }
     
        public Product(int ID, string Name, int quantity)
        {
            ProductID = ID;
            ProductName = Name;
            Quantity = quantity;
        }


    }

    /// <summary>
    /// Contains Shopping Cart information
    /// </summary>
    class ShoppingCart
    {
        public int OrderID { get; }
        public string ShopperName { get; }
        public string ShopperEmail { get; }
        public bool OrderCompleted { get; }

        public List<Product> Contents { get; }

        public ShoppingCart(int orderID, string shopperName, string shopperEmail,List<Product> list, bool oderCompleted)
        {
            this.OrderID = orderID;
            this.ShopperName = shopperName;
            this.ShopperEmail = shopperEmail;
            this.Contents = list;
            this.OrderCompleted = oderCompleted;
            Console.WriteLine("Shopping card is Created");
        }
    }
}
