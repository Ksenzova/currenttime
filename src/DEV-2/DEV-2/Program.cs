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
            
            string expression;
            // choose way of input
            ChooseInput choose = new ChooseInput();
            expression = choose.chooseInputWay(args);
            // check input data
            Checker checker = new Checker();
            // if input expression is valid calculate it
            if (checker.checkInputData(expression) == true)
            {
                Calculator calc = new Calculator();
                calc.calculate(expression);
            }
            Console.ReadKey();
        }
    }
}
