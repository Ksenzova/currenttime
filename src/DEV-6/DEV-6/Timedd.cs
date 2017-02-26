using System;

namespace DEV_6
{
    /// <summary>
    /// Return Month day from 01 to 31
    /// </summary>
    class Timedd : IFormat
    {
        public string GetData(DateTime curDate)
        { 
            string date = curDate.ToString();
            date = date.Substring(0, 2);
            return date;
        }
    }
}
