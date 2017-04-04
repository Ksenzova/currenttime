using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DEV_12
{
    public enum colour
    {
        black,
        white
    }

    /// <summary>
    /// Contains coordinates of checker field
    /// </summary>
    public struct Coordinate
    {
        public Coordinate(char x, ushort y)
        {
            if( Regex.Match(x.ToString(), @"[a-h]").Success)
            {
                X = x;
            }
            else
            {
                throw new RegexMatchTimeoutException();
            }
            if (Regex.Match(y.ToString(), @"[1-8]").Success)
            {
                Y = y;
            }
            else
            {
                throw new RegexMatchTimeoutException();
            }
        }

        public char X { get; set; }
        public ushort Y { get; set; }
    }

    public class Checker
    {
        public colour Colour { get; set; }
        public Coordinate CoordinateNeed { get; set; }      
        public Coordinate CoordiareCurrent { get; set; }
    }
}
