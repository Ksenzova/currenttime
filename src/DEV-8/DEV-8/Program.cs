using System;

namespace DEV_8
{
    /// <summary>
    /// Multiply two matrix if it is possible
    /// </summary>
    class Program
    {

        // Try catch  comments explain 
        static void Main(string[] args)
        {
            MatrixBuilder matrixBuilder = new MatrixBuilder();

            // Create matrix A
            Console.WriteLine("Input matrix size. Example 2x3");
            string sizeMatrix = Console.ReadLine();
            int[] size = matrixBuilder.GetMatrixSize(sizeMatrix);
            Console.WriteLine("Input elements of matrix");
            string inputString = Console.ReadLine();
            double[,] matrixA = matrixBuilder.GetMatrix(size[0], size[1], inputString);

            //Create matrix B
            Console.WriteLine("Input matrix size. Example 2x3");
            sizeMatrix = Console.ReadLine();
            size = matrixBuilder.GetMatrixSize(sizeMatrix);
            Console.WriteLine("Input elements of matrix");
            inputString = Console.ReadLine();
            double[,] matrixB = matrixBuilder.GetMatrix(size[0], size[1], inputString);

            // Multiply matrix A and matrix B
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
