using System.Collections.Generic;

namespace DEV_10
{
    /// <summary>
    /// Convert list of strings to list of Products
    /// </summary>
    class Convertor
    {
        public List<Product> GetProductList(List<string> initList)
        {
            List<Product> list = new List<Product>();

            foreach (string s in initList)
            {
                s.Trim('_');
                Product product = new Product(int.Parse(s.Split('_')[0]), s.Split('_')[1], int.Parse(s.Split('_')[2]));
                list.Add(product);
            }
            return list;       
        }
    }
}
