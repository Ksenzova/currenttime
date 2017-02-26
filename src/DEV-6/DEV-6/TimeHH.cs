using System;

namespace DEV_6
{
    /// <summary>
    /// Return hour from 00 to 23
    /// </summary>
    class TimeHH: IFormat
    {
        public string GetData(DateTime curDate)
        {
            string hour = curDate.ToLongTimeString();
            hour = hour.Substring(0, 2);
            return hour;
        }
    }
}
