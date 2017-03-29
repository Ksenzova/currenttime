namespace Tic_tac_toe
{
    /// <summary>
    /// Contains coordinates of input position
    /// </summary>
    class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Coordinate(int x, int y)
        {
            if (x>0 && y>0)
            {
                this.X = x;
                this.Y = y;
            }
            else
            {
                throw new System.Exception("Error input values of coordinate");
            }
            
        }

        /// <summary>
        /// Check input size accoding max size
        /// </summary>
        /// <param name="size">size</param>
        /// <returns>it math size or not</returns>
        public bool CheckSize(int size)
        {
            return ((X <= size) && (Y <= size)) ? true : false;
        }
    }
}
