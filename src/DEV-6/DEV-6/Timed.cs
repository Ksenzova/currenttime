using System;

namespace DEV_6
{
    /// <summary>
    /// Return Month day from 1 to 31
    /// </summary>
    class Timed : IFormat
    {
        public string GetData(DateTime curDate)
        {
            string date = curDate.ToString();
            date = date.Substring(0, 2);
            date.TrimStart('0');
            return date;
        }
    }   
}
