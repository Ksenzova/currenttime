using System;

namespace DEV_8
{
    class MatrixBuilder
    {
        public int[] GetMatrixSize()
        {
            string[] notformatSize;
            int[] size = new int[2];
            try
            {
                Console.WriteLine("input matix size. Example 2x3");
                string sizeMarix = Console.ReadLine();
                notformatSize = sizeMarix.Split('x');
                if(notformatSize.Length!=2)
                {
                    Console.WriteLine("Incorret form. Try input again");
                    size = GetMatrixSize();
                }
                for (int i = 0; i < notformatSize.Length; i++)
                {
                    size[i] = int.Parse(notformatSize[i]);
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("Incorret form. Try input again");
                size = GetMatrixSize();
            } 
            return size;
        }

        public double[,] GetMatrix(int rows, int coloms)
        {
            Console.WriteLine("Input matrix elements");
            string inputString = Console.ReadLine();
            string[] elements = inputString.Split(' ');
            double[,] matrix = new double[rows, coloms];
            if(elements.Length!= rows*coloms)
            {
                Console.WriteLine("Error input. Number of input elements do not match maitrixSize.Try inpput again ");
                matrix = GetMatrix(rows, coloms); 
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
                        matrix = GetMatrix(rows, coloms);
                    }
                }
            }
            return matrix;       
        }
    }
}
