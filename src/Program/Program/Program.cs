using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        /*
         *  Program that load read options from comand line and print random 3 options
         *  */
        const int options_number = 3;
        static void Main(string[] args)
        {
            if (args != null)
            {
                Selecter.Selecting(args,options_number);
            }
        }
    }
}
