using System.IO;

namespace DEV_10
{
    /// <summary>
    /// Write shopping cart in file
    /// </summary>
    class JsonBuilder
    {
        public void CreateJson(ShoppingCart shoppingCart, string outputPath)
        {
            using (StreamWriter sw = new StreamWriter(outputPath, false, System.Text.Encoding.Default))
            {
                sw.WriteLine("{");
                sw.WriteLine("  "+'"'+nameof(shoppingCart.OrderID)+'"' + ": " + '"'+shoppingCart.OrderID+'"'+',' );
                sw.WriteLine("  " + '"' + nameof(shoppingCart.ShopperName) + '"' + ": " + '"' + shoppingCart.ShopperName + '"' + ',');
                sw.WriteLine("  " + '"' + nameof(shoppingCart.ShopperEmail) + '"' + ": " + '"' + shoppingCart.ShopperEmail + '"' + ',');

                sw.WriteLine("  " + '"' + nameof(shoppingCart.Contents) + '"' + ": " + '[' );
                foreach (Product product in shoppingCart.Contents)
                {
                    sw.WriteLine("    {");
                    sw.WriteLine("      "+'"'+nameof(product.ProductID)+'"' + ": "+product.ProductID+',');
                    sw.WriteLine("      " + '"' + nameof(product.ProductName) + '"' + ": " + '"'+product.ProductName +'"'+ ',');
                    sw.WriteLine("      " + '"' + nameof(product.Quantity) + '"' + ": "+product.Quantity);
                    sw.WriteLine("    }"); 
                }
                sw.WriteLine("  ],");

                sw.WriteLine("  " + '"' + nameof(shoppingCart.OrderCompleted) + '"' + ": "+ shoppingCart.OrderCompleted);
                sw.WriteLine("}");
            }
        }
    }
}
