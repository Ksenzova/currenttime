using System;
using System.Collections.Generic;
using static DEV_6.Program;

namespace DEV_11
{
    /// <summary>
    /// Parse from input date need formats
    /// </summary>
    class Parser
    {
        public List<Format> GetFormats(string inputFormat)
        {
            string[] formatsNotParsed = inputFormat.Split(':',' ','.');
            List<Format> formats = new List<Format>();
            foreach(string s in formatsNotParsed)
            {
                formats.Add((Format)Enum.Parse(typeof(Format), s));
            }
            return formats;
        }

        public List<char>  GetSeparators(string inputFormat)
        {
            List<char> separators = new List<char>();
           foreach(char symb in inputFormat)
            {
                if(symb==':'||symb==' '|| symb == '.')
                {
                    separators.Add(symb);
                }
            }
            return separators;
        }
    }
}
