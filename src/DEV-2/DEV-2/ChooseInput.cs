using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_2
{
    // Choose one way of data input: commad line or console line
    class ChooseInput
    {
        // If there is no data in command line use console line
        public string chooseInputWay(string[] data)
        {

            if (data.Length == 0)
            {
                Console.WriteLine("Input Data");
                string data_console = Console.ReadLine();
                return data_console;
            }
            else
            {
                return string.Concat(data);
            }
        }
    }
}
