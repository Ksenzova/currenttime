using System;

namespace DEV_8
{
    /// <summary>
    /// Multiple two matrix
    /// </summary>
    class MatrixMultiplier
    {
        public double[,] MultiplyMatrix(double[,] matrixA, double[,] matrixB)
        {
            double[,] resultMatrix;
            if(matrixA.GetLength(1) == matrixB.GetLength(0))
            {
                resultMatrix = new double[matrixA.GetLength(0), matrixB.GetLength(1)];
                for(int i = 0; i< resultMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j<resultMatrix.GetLength(1); j++)
                    {
                        for (int r = 0; r< matrixA.GetLength(0); r++)
                        {
                            resultMatrix[i,j] += matrixA[i, r] * matrixB[r, j];
                        }
                    }
                }
            }
            else
            {
                throw new Exception("These matrixs cannot be multiplied");
            }
            return resultMatrix;
        }
    }
}
