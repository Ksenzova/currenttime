using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_2
{
    class Program
    {

        // Caclulating arithmetic expressions
        //  Using + - * / ()
        static void Main(string[] args)
        {
            ChooseInput choose = new ChooseInput();
            choose.chooseInputWay(args);
            Console.ReadKey();
        }
    }
}
