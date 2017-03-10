﻿using System;
using System.Collections.Generic;

namespace DEV_10
{
    /// <summary>
    /// Parse Json File
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            JsonParser jsonParser = new JsonParser();
            string toPath = "F://config.json";
            string inputPath = "F://new1.json";
            string outputPath = "";

            // Get fields to create Shopping Cart
            int oderID = int.Parse(jsonParser.GetField(inputPath, "orderID"));
            string shopperName = jsonParser.GetField(inputPath, "shopperName");
            string shopperEmail = jsonParser.GetField(inputPath, "shopperEmail");

            string[] fields = { "productID", "productName", "quantity" };
            List<string> initList = jsonParser.GetProducts(inputPath, fields);
            Convertor convertor = new Convertor();
            List<Product> list = convertor.GetProductList(initList);

            bool orderCompleted = bool.Parse(jsonParser.GetField(inputPath, "orderCompleted"));
            ShoppingCart shoppingCart = new ShoppingCart(oderID,shopperName,shopperEmail,list,orderCompleted);         

            Console.ReadKey();
        }
    }
}