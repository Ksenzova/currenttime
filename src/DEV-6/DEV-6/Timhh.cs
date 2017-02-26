using System;

namespace DEV_6
{
    /// <summary>
    /// Return hour from 00 to 12
    /// </summary>
    class Timhh:IFormat
    {
        int formatTime = 12;
        public string GetData(DateTime curDate)
        {
            string hour = curDate.ToLongTimeString();
            hour = hour.Substring(0, 2);
            int hourParse = int.Parse(hour);
            hourParse %= formatTime;
            hour = String.Empty;
            if (hourParse < 10)
                hour = "0";
            hour = String.Concat(hour,hourParse.ToString());
            return hour;
        }
    }
}
