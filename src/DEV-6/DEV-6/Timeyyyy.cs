using System;

namespace DEV_6
{ 
    /// <summary>
    /// Return year in full form
    /// </summary>
    class Timeyyyy : IFormat
    {
        public string GetData(DateTime curDate)
        {
            string date = curDate.ToString();
            string[] dateDev = date.Split('.', ' ');
            date = dateDev[2];
            return date;
        }
    }
}
