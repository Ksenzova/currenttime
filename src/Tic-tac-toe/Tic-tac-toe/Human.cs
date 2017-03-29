using System;
using System.Text.RegularExpressions;

namespace Tic_tac_toe
{
    class Human : Player
    {
        private Symbol symbol;
        private int size;

        private const string Input = "Input coodinates";
        private const string PositionIsFull = "This position has aleady full";
        private const string ErrorInput = "Error input position";
        private const string FieldIsFull = "All Field ia full";

        public Human(Symbol symbol, int size) : base(symbol, size)
        {
            this.symbol = symbol;
            this.size = size;
        }


        /// <summary>
        /// Analise field to set up symbolto input position
        /// </summary>
        /// <param name="field">field</param>
        /// <param name="size"></param>
        public override void Play(Field field)
        {
            Coordinate coordinate;
            do
            {
                Console.WriteLine(Input);
                int X = InputComponent();
                int Y = InputComponent();
                coordinate = new Coordinate(X, Y);
                if (field.IsAllFieldFull())
                {
                    throw new Exception(FieldIsFull);
                }
                if (!field.IsPositionFree(coordinate))
                {
                    Console.WriteLine(PositionIsFull);
                }
            } while (!field.IsPositionFree(coordinate));
            field.SetPosition(coordinate, symbol);
        }

        /// <summary>
        /// Try input component if it math example
        /// </summary>
        /// <returns>prsed input component</returns>
        private int InputComponent()
        {
            string strToCompare = string.Concat("[1-",size.ToString(),"]");
            Regex regex = new Regex(strToCompare);
            string strComponent = Console.ReadLine();
            while (!regex.IsMatch(@strComponent) )
            {
                Console.WriteLine(ErrorInput);
                strComponent = Console.ReadLine();
            }
            return int.Parse(strComponent);
        }
    }
}
