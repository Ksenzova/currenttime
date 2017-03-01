using System;

namespace DEV_6
{
    /// <summary>
    /// Return two last symbols of year
    /// </summary>
    class Timeyy : IFormat
    {
        public string GetData(DateTime curDate)
        {
            string date = curDate.ToString();
            string[] dateDev = date.Split('.', ' ');
            date = dateDev[2];
            date = date.Substring(2,2);
            return date;
        }
    }
}
