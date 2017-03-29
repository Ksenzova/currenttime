 namespace Tic_tac_toe
{
    public struct ArrayFormater<T>
    {
        private readonly T[,] array;
        public ArrayFormater(T[,] array)
        {
            this.array = array;
        }

        public T[] GetRow(int row)
        {
            T[] mass = new T[array.GetLength(1)];
            for (int i = 0; i < array.GetLength(1); i++)
            {
                mass[i] = array[row, i];
            }
            return mass;
        }

        public T[] GetColomn(int colomn)
        {
            T[] mass = new T[array.GetLength(0)];
            for (int i = 0; i < array.GetLength(1); i++)
            {
                mass[i] = array[i, colomn];
            }
            return mass;
        }

        public T[] GetMainDiagonals()
        {
            T[] mass = new T[array.GetLength(0)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        mass[i] = array[i, j];
                    }
                }
            }
            return mass;
        }

        public T[] GetSecondaryDiagonals()
        {
            T[] mass = new T[array.GetLength(0)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j <array.GetLength(1); j++)
                {
                    if (i + j == array.GetLength(1) - 1)
                    {
                        mass[i] = array[i, j];
                    }
                }
            }
            return mass;
        }


    }
}
