namespace Tic_tac_toe
{
    /// <summary>
    /// Contains playing field 
    /// </summary>
    class Field
    {
        private Symbol[,] positions;
        private int size;

        public Symbol[,] Positions
        {
            get { return positions;}
        }

        /// <summary>
        /// Create Field 
        /// </summary>
        /// <param name="size"></param>
        public Field(int size)
        {
            this.size = size;
            positions = new Symbol[size, size];
            for(int i = 0; i<size; i++ )
            {
                for(int j = 0;j< size; j++)
                {
                    Positions[i, j] = Symbol.empty;
                }
            }
        } 

        /// <summary>
        /// Set choosing symbol tofield
        /// </summary>
        /// <param name="coordinat">coordinates to set symbol</param>
        /// <param name="symbol">type of symbol to set</param>
        public void SetPosition(Coordinate coordinat,Symbol symbol)
        {
            Positions[coordinat.X-1, coordinat.Y-1] = symbol;
        }

        /// <summary>
        /// Check is position is free
        /// </summary>
        /// <param name="coordinate">coordinate checking position</param>
        /// <returns>is position is free</returns>
        public bool IsPositionFree(Coordinate coordinate)
        {
            bool isFull = false;
            if (Positions[coordinate.X-1,coordinate.Y-1] == Symbol.empty)
            {
                isFull = true;
            } 
            return isFull;
        } 
        
        /// <summary>
        /// Check is field full
        /// </summary>
        /// <returns>is field full or not</returns>
        public bool IsAllFieldFull()
        {
            bool isFull = true;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (Positions[i,j] == Symbol.empty)
                    {
                        isFull = false;
                        break;
                    }
                }
            }
            return isFull;
        }  

        /// <summary>
        /// Override method ToString formating input field
        /// </summary>
        /// <returns>field formatedto string</returns>
        public override string ToString()
        {
            string fieldToOutput = string.Empty;
            for (int i = 0; i< size; i++)
            {
                for (int j = 0; j<size; j++)
                {
                    fieldToOutput =Positions[i,j]!=Symbol.empty?string.Concat(fieldToOutput,"| ", Positions[i, j]," |"): 
                        string.Concat(fieldToOutput, "|   |");
                }
                fieldToOutput = string.Concat(fieldToOutput,"\n");
            }
            return fieldToOutput;
        }               
    }
}
