using System;
using System.Collections.Generic;
using System.Linq;

namespace Tic_tac_toe
{
    class Judge
    {
        Symbol[,] positions;
        int size;
        
        public Judge(Field field, int size)
        {
            positions = field.Positions;
            this.size = size;
        }

        /// <summary>
        /// Find winner of current game if one of the rows,coloms contain number of the same symbol euqual to size of field 
        /// </summary>
        /// <param name="field">current field</param>
        /// <returns>win anyone or no</returns>
        public bool FindWinner(ArrayFormater<Symbol> formater)
        {
            List<string> listOfWinnerPositions = new List<string>();
            for(int i= 0; i< size; i++)
            {
                listOfWinnerPositions.Add(string.Concat(formater.GetRow(i)));
                listOfWinnerPositions.Add(string.Concat(formater.GetColomn(i)));
            }
            listOfWinnerPositions.Add(string.Concat(formater.GetMainDiagonals()));
            listOfWinnerPositions.Add(string.Concat(formater.GetSecondaryDiagonals()));

            bool flag = false;
            foreach (string sd in listOfWinnerPositions)
            {
                if (sd.ToCharArray().Where(i => i == 'X').Count() == size)
                {
                    Console.WriteLine("Win X");
                    flag= true;
                }
                else
                {
                    if (sd.ToCharArray().Where(i => i == 'O').Count() == size)
                    {
                        Console.WriteLine("Win O");
                        flag= true;
                    }
                }        
            }
            return flag;
        }
    }
}
