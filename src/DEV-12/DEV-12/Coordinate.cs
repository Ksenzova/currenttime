using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DEV_12
{
    /// <summary>
    /// Contains coordinaates of fields on chess draughts board
    /// </summary>
    public class Coordinate
    {        
        public char X { get; set; }
        public int Y { get; set; }

        public Coordinate(char x, ushort y)
        {
            // If math these expression create Coordinate, else throw exeption
            if (Regex.Match(x.ToString(), @"[a-h]").Success && Regex.Match(y.ToString(), @"[1-8]").Success)
            {
                X = x;
                Y = y;
            }
            else
            {
                throw new RegexMatchTimeoutException("Error input coordinate");
            }
        }

        /// <summary>
        /// Convert X coordinate to number
        /// </summary>
        /// <param name="coordinate">char value</param>
        /// <returns>int value of X component of coordinate</returns>
        public int ConvertXToInt()
        {
            char[] pole = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
            List<char> list;
            list = new List<char>(pole);
            return list.IndexOf(X)+1;
        } 
        /// <summary>
        /// Convert number to X component of coordinate 
        /// </summary>
        /// <param name="number">number of X component</param>
        /// <returns>X component of coordinate</returns>
        public static char ConvertXToChar(int number)
        {
            char[] pole = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
            return pole[number-1];
        } 

        /// <summary>
        /// Overload operator == to compare two coordinates
        /// </summary>
        /// <param name="a">first coordinate to compare</param>
        /// <param name="b">second coordinate to compare</param>
        /// <returns>if these coordinates the same</returns>
        public static bool operator ==(Coordinate a, Coordinate b)
        {
            return (a.X == b.X && a.Y == b.Y) ? true : false;
        }

        /// <summary>
        /// Overload operator != to compare two coordinates
        /// </summary>
        /// <param name="a">first coordinate to compare</param>
        /// <param name="b">second coordinate to compare</param>
        /// <returns>if these coordinates are not the same</returns>
        public static bool operator !=(Coordinate a, Coordinate b)
        {
            return (a.X != b.X || a.Y != b.Y) ? true : false;
        }
        
        /// <summary>
        /// Ovverride method ToString() to out out coordinate
        /// </summary>
        /// <returns>coordinate formed to string</returns>
        public override string ToString()
        {
            return string.Concat(X , Y.ToString());
        }    
    }
}
