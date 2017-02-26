using System;

namespace DEV_6
{
    /// <summary>
    /// Return day of week in short form
    /// </summary>
    class Timeddd: IFormat
    {
        public string GetData(DateTime day)
        {
            string weekDay = day.DayOfWeek.ToString();
            weekDay = weekDay.Substring(0, 3);   
            return weekDay;
        }
    }
}
