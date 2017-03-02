using System;

namespace DEV_8
{
    class Printer
    {
        /// <summary>
        /// Print matrix in matrix form
        /// </summary>
        public static void Print(double[,] matrix)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("   {0}   ", matrix[i, j]);
                }
                Console.WriteLine("");
            }
        }
    }
}
