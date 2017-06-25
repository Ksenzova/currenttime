using System;
using System.Collections.Generic;
using System.IO;

namespace DEV_10
{
    /// <summary>
    /// Parse Json File
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                JsonParser jsonParser = new JsonParser();
                string toPath = "F:/AT/currenttime/src/DEV-10/DEV-10/config.json";

                string inputPath = jsonParser.GetField(toPath, "input");
                string outputPath = jsonParser.GetField(toPath, "output");

                // Get fields to create Shopping Cart
                int oderID = int.Parse(jsonParser.GetField(inputPath, "orderID"));

                string shopperName = jsonParser.GetField(inputPath, "shopperName");
                string shopperEmail = jsonParser.GetField(inputPath, "shopperEmail");

                string[] fields = { "productID", "productName", "quantity" };
                List<string> initList = jsonParser.GetProducts(inputPath, fields);
                Convertor convertor = new Convertor();
                List<Product> list = convertor.GetProductList(initList);

                bool orderCompleted = bool.Parse(jsonParser.GetField(inputPath, "orderCompleted"));
                ShoppingCart shoppingCart = new ShoppingCart(oderID, shopperName, shopperEmail, list, orderCompleted);

                // Create Json file
                JsonBuilder jsBuilder = new JsonBuilder();
                jsBuilder.CreateJson(shoppingCart, outputPath);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
