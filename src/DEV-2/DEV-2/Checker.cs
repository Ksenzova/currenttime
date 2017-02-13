using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_2
{
    // Check input arithmetic expression
    class Checker
    {
        private bool correctExpression = true;

        // If  input data correct return true 
        public bool checkInputData(string data)
        {
            // Remove " " symbols
            data.Replace(" ", "");

            // Check not valid symbols
            // incorrect positions of operations
            // first and last symbols
            if ((checkSymbols(data) == false) || (checkOperationsPosition(data) == false) || (checkFirstLastSymbol(data) == false))
            {
                Console.Write("Error input");
                correctExpression = false;
            }

            // Check Brackets
            if (checkBrackets(data) == false)
            {
                Console.Write("Numbers of ( and ) is not the same");
                correctExpression = checkBrackets(data);
            }

            return correctExpression;
        }

        // Check number of "(" and ")"
        private bool checkBrackets(string data)
        {
            bool check = true;
            int numberofLeft = 0;
            int numberofRight = 0;

            foreach (char c in data)
            {
                if (c == '(')
                    numberofLeft++;
                if (c == ')')
                    numberofRight++;
            }
            if (numberofLeft != numberofRight)
                check = false;

            return check;
        }

        // Check first and last symbols in data 
        private bool checkFirstLastSymbol(string data)
        {
            bool check = true;

            if ((data[0] == '+') || (data[0] == '-') || (data[0] == '*') || (data[0] == '/'))
                check = false;

            if ((data[data.Length - 1] == '+') || (data[data.Length - 1] == '-') || (data[data.Length - 1] == '*') || (data[data.Length - 1] == '/'))
                check = false;

            return check;
        }

        // Check error input 
        // If there is  two operation standing near return false
        private bool checkOperationsPosition(string data)
        {
            bool previosIsOperation = false;
            bool currentSymbol = false;
            bool check = true;

            foreach (char c in data)
            {
                if (c == '*' || c == '-' || c == '+' || c == '/')
                    currentSymbol = true;
                else
                    currentSymbol = false;
                if (currentSymbol == true && previosIsOperation == true)
                {
                    check = false;
                    break;
                }
                previosIsOperation = currentSymbol;
            }
            return check;
        }

        // Check error symbols
        // if there are not valid symbols return false
        private bool checkSymbols(string data)
        {
            bool check = true;
            foreach (char symb in data)
            {
                if ((symb != '.') && (symb != '+') && (symb != '-') && (symb != '*') && (symb != '/') && (symb != '(') && (symb != ')') && (!Char.IsDigit(symb)))
                {
                    check = false;
                    break;
                }
            }
            return check;
        }
    }
}
