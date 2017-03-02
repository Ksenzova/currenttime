using System;

namespace DEV_8
{
    /// <summary>
    /// Form matrix
    /// </summary>
    class MatrixBuilder
    {
        /// <summary>
        /// Get size of matrix if it is possible
        /// If input value are incorrect requests re-entry
        /// </summary>
        /// <param name="sizeMatrix">not parsed input string which contains size</param>
        /// <returns>size of matrix</returns>
        public int[] GetMatrixSize(string sizeMatrix)
        {
            string[] notformatSize;
            int[] size = new int[2];
            try
            {
                notformatSize = sizeMatrix.Split('x');
                if(notformatSize.Length!=2)
                {
                    Console.WriteLine("Incorret form. Try input again");
                    size = GetMatrixSize(Console.ReadLine());
                }
                for (int i = 0; i < notformatSize.Length; i++)
                {
                    size[i] = int.Parse(notformatSize[i]);
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("Incorret form. Try input again");
                size = GetMatrixSize(Console.ReadLine());
            } 
            return size;
        }

        /// <summary>
        /// Get matrix  of input size
        /// If input value are incorrect requests re-entry
        /// </summary>
        /// <param name="inputString">not parsed string which contains element of matrix</param>
        /// <returns>matrix</returns>
        public double[,] GetMatrix(int rows, int coloms, string inputString)
        {
            inputString = inputString.Trim(' ');
            string[] elements = inputString.Split(' ');
            double[,] matrix = new double[rows, coloms];
            if(elements.Length!= rows*coloms)
            {
                Console.WriteLine("Error input. Number of input elements do not match matrixSize.Try input again ");
                matrix = GetMatrix(rows, coloms, Console.ReadLine()); 
            }
            int elementIndex = 0;         
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < coloms; j++)
                {
                    try
                    {
                        matrix[i, j] = Convert.ToDouble(elements[elementIndex]);
                        elementIndex++;
                    }
                    catch(FormatException)
                    {
                        Console.WriteLine("Error input. Elements are not valid ");
                        matrix = GetMatrix(rows, coloms,Console.ReadLine());
                    }
                }
            }
            return matrix;       
        }
    }
}
