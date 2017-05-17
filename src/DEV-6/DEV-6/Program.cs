using DEV_11;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace DEV_6
{
    /// <summary>
    /// Return date in input format
    /// </summary>
    public class Program
    {
        /// <summary>
        /// All types of format
        /// </summary>
        public enum Format
        {
            h,
            hh,
            H,
            HH,
            dddd,
            ddd,
            dd,
            d,
            yyyy,
            yyy,
            yy,
            y,
            MM,
            MMM,
            MMMM
        }
        static void Main(string[] args)
        {
            DateTime curDate = DateTime.Now;
            Console.WriteLine(curDate);
            try
            {
                string formedDate = string.Empty;
                Console.WriteLine("Input format");
                string inputFormat = Console.ReadLine();
                Parser parser = new Parser();
                List<Format> formats =  parser.GetFormats(inputFormat);
                List<char> separators = parser.GetSeparators(inputFormat);
                FormatBuilder formatBuilder = new FormatBuilder();
                formedDate = formatBuilder.BuildFormat(formats,separators,curDate);
                Console.WriteLine(formedDate);
             }
            catch (ArgumentException)
            {
                Console.WriteLine("Not valid format");
            }          
            Console.ReadKey();
        }
    }
}
