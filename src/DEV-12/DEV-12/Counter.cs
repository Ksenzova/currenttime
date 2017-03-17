using System;
using System.Collections.Generic;

namespace DEV_12
{
    /// <summary>
    /// Count number of step to achieve need fieeld if it is possible
    /// </summary>
    public class Counter
    {
        char[] pole = { 'a', 'b', 'c','d','e', 'f', 'g', 'h' };
        const int SIZE = 8;
        const int RIGHT = 9;
        const int LEFT = 7;
        int[] list = { 7, 7, 7, 7, 7, 7, 7, 7, 9, 9, 9, 9, 9, 9, 9, 9 };
       
        /// <summary>
        /// Caclulate number of steps need to achieve input field
        /// </summary>
        /// <param name="cheque">contains all parametrs of checker</param>
        /// <returns>number of steps</returns>
         public int GetNumberOfSteps(Checker checker)
        {
            int numberOfSteps = 0;
            
            int current = CalculateCoordinate(checker.CoordiareCurrent);
            int need = CalculateCoordinate(checker.CoordinateNeed);
            int difference = need - current ;
            if ((IfValidInputField(checker.CoordinateNeed)==false)||(IfValidInputField(checker.CoordinateNeed) == false))
            {
                throw new NotValidInputField("Error input of coordinate. Unavaible to put checker on white fields");
            }

            if (checker.Colour == colour.black)
            {
                difference *= (-1);
            }

            for(int i = 0; i<8; i++)
            {
                for (int j = 0; j<8; j ++)
                {
                    if ((difference)==(i*RIGHT +j*LEFT))
                    {
                        numberOfSteps = i + j ;
                    }
                }
            }

            if (numberOfSteps==0)
            {
                throw new CannotAchieve("Immposible achieve need field");
            }
            
            return numberOfSteps;
        }


        /// <summary>
        /// Check standing checker only on black fields
        /// </summary>
        /// <param name="coordinate">coordinate field</param>
        /// <returns></returns>
        private bool IfValidInputField(Coordinate coordinate)
        {
            bool isValid = true;
            if ((coordinate.Y%2==1) && (CalculateCoordinate(coordinate)%2==0))
            {
                isValid = false;
            }
            if ((coordinate.Y % 2 == 0) && (CalculateCoordinate(coordinate) % 2 == 1))
            {
                isValid = false;
            } 
            return isValid;
        }

        /// <summary>
        /// Calculate coordinates as value of  One-dimensional array
        /// </summary>
        /// <param name="coordinate">coordinate of field</param>
        /// <returns>coordinates in line form</returns>
        private int CalculateCoordinate(Coordinate coordinate)
        {
            List<char> list = new List<char>(pole);
            return (coordinate.Y - 1) * SIZE + list.IndexOf(coordinate.X) + 1;
        }    

    }
  
}
