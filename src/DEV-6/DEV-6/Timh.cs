using System;

namespace DEV_6
{
    /// <summary>
    /// Return hour from 0 to 12
    /// </summary>
    class Timh : IFormat
    {
        public string GetData(DateTime curDate)
        {
            string hour = curDate.ToLongTimeString();
            hour = hour.Substring(0, 2);
            int hourParse = int.Parse(hour);
            hourParse %= 12;
            hour = hourParse.ToString();
            return hour;
        }
    }
}
