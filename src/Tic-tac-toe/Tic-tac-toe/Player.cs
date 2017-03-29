namespace Tic_tac_toe
{
    public enum Symbol
    {
        X,
        O,
        empty
    }
    abstract class Player
    {
        private Symbol symbol;
        private int size;

        public Player(Symbol symbol, int size)
        {
            this.symbol = symbol;
            this.size = size;
        }

        /// <summary>
        /// Analise field to set up symbol to input position
        /// </summary>
        /// <param name="field">field</param>
        public abstract void Play(Field field);
    }
}
