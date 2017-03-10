using System.Collections.Generic;

namespace DEV_10
{
    interface IParseJson
    {
        string GetField(string path, string field);

        List<string> GetProducts(string path, string[] fields);
    }
}
