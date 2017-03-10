using System.Collections.Generic;
using System.IO;

namespace DEV_10
{
    /// <summary>
    /// Parse Json File
    /// </summary>
    class JsonParser: IParseJson
    {
        /// <summary>
        /// Get value of input symbol
        /// </summary>
        /// <param name="path"> path of json file</param>
        /// <param name="field">field contains need value</param>
        /// <returns> value of field </returns>
        public string GetField(string path, string field)
        {
            string value = string.Empty;
            foreach (string line in File.ReadAllLines(path))
            {
                line.Trim(' ',',');
                if (line.Contains(field))
                {
                    value = line.Split(':')[1].Trim(',',' ','"');
                }
           }
            return value;
        }

        /// <summary>
        /// Parse Lists in Json file
        /// </summary>
        /// <param name="path"> path of json file</param>
        /// <param name="field">field contains element of list</param>
        /// <returns>string List contains information about product</returns>
        public List<string> GetProducts(string path,string[] fields)
        {
            List<string> list = new List<string>();
            string value = string.Empty;
            string obj = string.Empty;
            foreach (string line in File.ReadAllLines(path))
            {
                line.Trim(' ', ',');
                foreach (string s in fields)
                {
                    if (line.Contains(s))
                    {
                        value = line.Split(':')[1].Trim(',', ' ', '"');

                        if (obj != string.Empty)
                        {
                            obj += "_";
                        }
                        obj += value;
                    }   
                }
                if (obj!=string.Empty && obj.Split('_').Length==fields.Length)
                {
                    list.Add(obj);
                    obj = string.Empty;
                }
            }         
            return list;
        }
    }
}
