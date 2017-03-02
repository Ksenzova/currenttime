using System;

namespace DEV_8
{
    /// <summary>
    /// Multiply two matrix if it is possible
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            MatrixBuilder matrixBuilder = new MatrixBuilder();
            int[] size = matrixBuilder.GetMatrixSize(); 
            double[,] matrixA = matrixBuilder.GetMatrix(size[0], size[1]);

            size = matrixBuilder.GetMatrixSize();  
            double[,] matrixB = matrixBuilder.GetMatrix(size[0], size[1]);

            MatrixMultiplier matrixMultiplier = new MatrixMultiplier();
            try
            {
                double[,] resultMatrix = matrixMultiplier.MultiplyMatrix(matrixA, matrixB);
                Printer.Print(resultMatrix);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
