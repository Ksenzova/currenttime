using System;

namespace Tic_tac_toe
{
    /// <summary>
    /// Computer player generate positions random
    /// </summary>
    class Computer: Player
    {
        private Symbol symbol;
        private int size;

        public Computer(Symbol symbol, int size) : base(symbol, size)
        {
            this.symbol = symbol;
            this.size = size;
        }

        /// <summary>
        /// Conputer generate random position if this position us full generate it again
        /// </summary>
        /// <param name="field">fiel</param>
        /// <param name="size">sizeof field</param>
        public override void Play(Field field)
        {
            Random random = new Random();
            Coordinate coordinate = new Coordinate(random.Next(1,size +1), random.Next(1, size + 1));
            while(!field.IsPositionFree(coordinate))
            { 
                int X = random.Next(1,size+1);
                int Y = random.Next(1,size+1);
                coordinate = new Coordinate(X, Y);  
                if (field.IsAllFieldFull())
                {
                    throw new Exception("Fiel is full");
                }   
            }                
            field.SetPosition(coordinate, symbol); 
        }
    }
}