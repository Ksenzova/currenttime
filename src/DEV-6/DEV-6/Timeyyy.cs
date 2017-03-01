using System;

namespace DEV_6
{
    /// <summary>
    /// Return year in full form or only three symbols if year is less than 1000
    /// </summary>
    class Timeyyy : IFormat
    {
        public string GetData(DateTime curDate)
        {
            string date = curDate.ToString();
            string[] dateDev = date.Split('.', ' ');
            date = dateDev[2];
            date.TrimStart('0');
            return date;
        }
    }
}
