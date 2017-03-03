using System;
using System.IO;

namespace DEV_9
{
    /// <summary>
    /// Find in File value by section and key
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string path =string.Empty;
            try
            {
                path = args[0];
                bool isExist = File.Exists(path);
                if(isExist==true)
                {
                    Console.WriteLine("Input section");
                    string section = Console.ReadLine();
                    section = string.Concat('[', section, ']');

                    Console.WriteLine("Input key");
                    string key = Console.ReadLine();

                    FileReader fileReader = new FileReader();
                    string value = fileReader.GetValue(section, key, path);
                    if(value == string.Empty)
                    {
                        Console.WriteLine("There is no value for section{0}, key{1}", section, key);
                    }
                    Console.WriteLine(value);
                }
                else
                {
                    Console.WriteLine("Could not find specified path");
                }
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("There is no input path"); 
            }    
               
            Console.ReadKey();
        }
    }
}
