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
        public void chooseInputWay(string[] data)
        {
            Checker checker = new Checker();
            if (data.Length == 0)
            {
                Console.WriteLine("Input Data");
                string data_console = Console.ReadLine();
                if (checker.checkInputData(data_console) == true)
                {
                    Calculator calc = new Calculator();
                    calc.calculate(data_console);
                }
            }
            else
                if (checker.checkInputData(string.Concat(data)) == true)
            {
                Calculator calc = new Calculator();
                calc.calculate(string.Concat(data));
            }
        }
    }
}
