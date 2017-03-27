namespace DEV_12
{
    /// <summary>
    /// New type of variable to colour of draught
    /// </summary>
    public enum colour
    {
        black,
        white
    }

    /// <summary>
    /// Contains parametres of draught: colour and current coordinate
    /// </summary>
    public class Draught
    {
        private Coordinate coordinateCurrent;

        private colour colourDraught;

        internal Coordinate CoordinateCurrent
        {
            get { return coordinateCurrent; }
            set { coordinateCurrent = value; }
        }

        public colour Colour
        {
            get { return colourDraught; }
            set { colourDraught = value;}
        }

        public Draught (colour Colour, Coordinate coordinate)
        {
            this.Colour = Colour;
            this.coordinateCurrent = coordinate;
        }

        /// <summary>
        /// Change current position of coordinate moving it left
        /// </summary>
        public void MoveLeft()
        {
            // white draught can move only up
            // black draught can move only down
            coordinateCurrent.Y = Colour == colour.white?CoordinateCurrent.Y+1: CoordinateCurrent.Y - 1;
            coordinateCurrent.X = Coordinate.ConvertXToChar(CoordinateCurrent.ConvertXToInt() - 1);
        }

        /// <summary>
        /// Change current position of coordinate moving it right
        /// </summary>
        public void MoveRight()
        {
            // white draught can move only up
            // black draught can move only down
            coordinateCurrent.Y = Colour == colour.white ? CoordinateCurrent.Y + 1 : CoordinateCurrent.Y - 1;
            coordinateCurrent.X = Coordinate.ConvertXToChar(CoordinateCurrent.ConvertXToInt() + 1);
        }
    }
}
