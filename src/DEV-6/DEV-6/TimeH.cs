using System;

namespace DEV_6
{
    /// <summary>
    /// Return hour from 0 to 23
    /// </summary>
    class TimeH : IFormat
    {
        public string GetData(DateTime curDate)
        {
            string hour = curDate.ToLongTimeString();
            hour = hour.Substring(0, 2);
            hour.TrimStart('0');   
            return hour;
        }
    }
}
