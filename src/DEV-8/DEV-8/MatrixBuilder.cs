using System;

namespace DEV_8
{
    /// <summary>
    /// Form matrix
    /// </summary>
    class MatrixBuilder
    {
        private const string IncorrectForm = "Incorrect form. Try input again. Example 2x3";
        private const string InputSymbolsAreNotNumbers = "Input symbol are not numbers.Try input again.";
        private const string ErrorNumberOfElements = "Error input. Number of input elements do not match matrixSize.\nTry input again:";  

        private int rows;
        private int coloms;
        private string[] notConvertSize;
        private string[] notparsedElems;
        private double[] elements;

        /// <summary>
        /// Get size of matrix if it is possible
        /// If input value are incorrect requests re-entry
        /// </summary>
        /// <param name="sizeMatrix">not parsed input string which contains size</param>
        /// <returns>size of matrix</returns>
        public void GetMatrixSize(string sizeMatrix)
        {      
            // Control right input format of size and input numbers
            // if its false call overwriting    
            bool flag = false;

            while(!flag)
            {
                notConvertSize = sizeMatrix.Split('x');                
                if (notConvertSize.Length!= 2)
                {
                    Console.WriteLine(IncorrectForm);
                    sizeMatrix = Console.ReadLine();
                }
                else
                {
                    if (!int.TryParse(sizeMatrix.Split('x')[0], out rows) || !int.TryParse(sizeMatrix.Split('x')[1], out coloms))
                    {
                        Console.WriteLine(InputSymbolsAreNotNumbers);
                        sizeMatrix = Console.ReadLine();
                    }
                    else
                    {
                        flag = true;
                    }
                }
            }          
        }

        /// <summary>
        /// Get matrix  of input size
        /// If input value are incorrect requests re-entry
        /// </summary>
        /// <param name="inputString">not parsed string which contains element of matrix</param>
        /// <returns>formed matrix</returns>
        public Matrix GetMatrix(string inputString)
        {
            // Control number of elements, if these eleements are numbers and can be parsed to double
            // is it is flase call overwriting 
            bool flag = false;
            bool isElementsCanBeParsed = true;
           
            while (!flag)
            {
                inputString = inputString.Trim(' ');
                notparsedElems = inputString.Split(' ');
                elements = new double[notparsedElems.Length];
                if (elements.Length != rows * coloms)
                {
                    Console.WriteLine(ErrorNumberOfElements);
                    inputString = Console.ReadLine();
                }
                else
                {
                    for (int i = 0; i < elements.Length; i++)
                    {
                        isElementsCanBeParsed = double.TryParse(notparsedElems[i], out elements[i]);
                        if (!isElementsCanBeParsed)
                        {
                            break;
                        }
                    }
                    if (!isElementsCanBeParsed)
                    {
                        Console.WriteLine(InputSymbolsAreNotNumbers);
                        inputString = Console.ReadLine();
                    }
                    else
                    {
                        flag = true;
                    }
                }                   
            }
            return new Matrix(ConvertToTwoDemensionalArray());       
        }

        /// Convert one-dimensional array to two-dimensional array
        private double [,] ConvertToTwoDemensionalArray()
        {
            double[,] resultElements = new double[rows, coloms];
            int elem = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < coloms; j++)
                {
                    resultElements[i, j] = elements[elem];
                    elem++;
                }
            }
            return resultElements;
        }
    }
}
