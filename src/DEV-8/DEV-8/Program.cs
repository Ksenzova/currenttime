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
            try
            { 
                MatrixBuilder matrixBuilder = new MatrixBuilder();

                // Create matrix A
                Console.WriteLine("Input matrix size. Example 2x3");
                string sizeMatrix = Console.ReadLine();
                matrixBuilder.GetMatrixSize(sizeMatrix);
                Console.WriteLine("Input elements of matrix");
                string inputString = Console.ReadLine();
                Matrix matrixA = matrixBuilder.GetMatrix(inputString);

                // Create matrix B
                Console.WriteLine("Input matrix size. Example 2x3");
                sizeMatrix = Console.ReadLine();
                matrixBuilder.GetMatrixSize(sizeMatrix);
                Console.WriteLine("Input elements of matrix");
                inputString = Console.ReadLine();
                Matrix matrixB = matrixBuilder.GetMatrix(inputString);
                
                // Multiply matrix A and matrix B
                Matrix resultMatrix = matrixA * matrixB;
                Console.WriteLine("Matix A");
                Console.WriteLine(matrixA.ToString());
                Console.WriteLine("Matix B");
                Console.WriteLine(matrixB.ToString());
                Console.WriteLine("Matix A*B");
                Console.WriteLine(resultMatrix.ToString());
                          
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
