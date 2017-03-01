using System;

namespace DEV_6
{
    /// <summary>
    /// Return day of week in full form
    /// </summary>
    class Timedddd : IFormat
    {
        public string GetData(DateTime day)
        {
            string weekDay = day.DayOfWeek.ToString();
            return weekDay;
        }
    }
}
