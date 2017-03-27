using System;

namespace DEV_12
{
    /// <summary>
    /// Parse from input string coordinate need, coordindte currrent, and colour of draught
    /// </summary>
    class Parser
    {
        // Parsed paramtres
        private Coordinate coordinateNeed;
        private Coordinate coordinateCurrent;
        private colour draughtColour;

        public Coordinate CoordinateNeed
        {
            get { return coordinateNeed;}
            private set {;}
        }

        public Coordinate CoordinateCurrent
        {
            get { return coordinateCurrent;}
            private set {; }
        }

        public colour DraughtColour
        {
            get { return draughtColour;}
            private set {; }
        }

        /// <summary>
        /// Try parse parameters
        /// </summary>
        /// <param name="inputString">input string wich contain not parsed parametres</param>
        /// <returns>posibiliyt of parsing parametres</returns>
        public bool TryParseParams(string inputString)
        {
            bool flag = true;
            string[] parameters = inputString.Trim(' ').Split(' ');
            flag = Enum.TryParse(parameters[0], out draughtColour);       
            try
            {
                char[] symbols = parameters[1].ToCharArray();
                coordinateCurrent = new Coordinate(symbols[0], (ushort)symbols[1]);
                symbols = parameters[2].ToCharArray();
                coordinateNeed = new Coordinate(symbols[0], (ushort)symbols[1]);
            }
            catch
            {
                flag = false;
            }       
            return flag;
        }
    }
}
