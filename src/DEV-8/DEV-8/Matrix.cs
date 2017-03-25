using System;

namespace DEV_8
{
    /// <summary>
    /// Contains elements of  matrix, size of matrix
    /// And methods allows multiply matrix
    /// </summary>
    class Matrix
    {
        public double[,] MatrixElements { get; set; }
        public int Rows { get; private set; }
        public int Coloms { get; private set; }

        /// <summary>
        /// Create empty matrix
        /// </summary>
        /// <param name="rows">number of rows in matrix</param>
        /// <param name="coloms">number of coloms in matrix</param>
        public  Matrix(int rows, int coloms)
        {
            this.Rows = rows;
            this.Coloms = coloms;
        }

        /// <summary>
        /// Create matrix
        /// </summary>
        /// <param name="elements">element of matrix</param>
        public Matrix(double[,] elements)
        {
            this.MatrixElements = elements;
            Rows = MatrixElements.GetLength(0);
            Coloms = MatrixElements.GetLength(1);
        }

        /// <summary>
        /// Multiply matrix
        /// </summary>
        /// <param name="matrixA">multiplied matrix</param>
        /// <param name="matrixB">matrix multiplied by</param>
        /// <returns>result matrix</returns>
        public static Matrix operator *(Matrix matrixA,Matrix matrixB)
        {
            double[,] resultMatrix;
            // if number of coloms of multiplied matrix is the same to number of rows of matrix multiplied by
            // it is possible to multiply matrix
            if (matrixA.MatrixElements.GetLength(1) == matrixB.MatrixElements.GetLength(0))
            {
                resultMatrix = new double[matrixA.MatrixElements.GetLength(0), matrixB.MatrixElements.GetLength(1)];
                // C[i,j] = A[i,k]*B[k,j] 
                for (int i = 0; i < resultMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < resultMatrix.GetLength(1); j++)
                    {
                        for (int r = 0; r < matrixA.MatrixElements.GetLength(0); r++)
                        {
                            resultMatrix[i, j] += matrixA.MatrixElements[i, r] * matrixB.MatrixElements[r, j];
                        }
                    }
                }
                return new Matrix(resultMatrix);
            }
            else
            {
                throw new Exception("These matrices cannot be multiplied");
            }
        }

        /// <summary>
        /// Override method ToString() allows form matrix to string convenient to print
        /// </summary>
        /// <returns> matrix convert to string</returns>
        public override string ToString()
        {
            string matrixToPrint = string.Empty;
            for (int i = 0; i < MatrixElements.GetLength(0); i++)
            {
                for(int j = 0; j<MatrixElements.GetLength(1); j++)
                {
                     matrixToPrint = string.Concat(matrixToPrint, MatrixElements[i,j]," ");
                }
                matrixToPrint = string.Concat(matrixToPrint, "\n");
            }
            return matrixToPrint;
        }
    }
}


