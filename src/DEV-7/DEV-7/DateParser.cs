namespace DEV_7
{
    /// <summary>
    /// Parse input date and time 
    /// Fill stogage of date and time
    /// </summary>
    class DateParser
    {
        private char[] separators = { ':', '.', ' ' };

        private const int MonthPriority = 0;
        private const int DayPriority = 1;
        private const int YearPriority = 2;
        private const int HourPriority = 3;
        private const int MinutePriority = 4;
        private const int SecondPriority = 5;

        public void ParseData(string inputDate, ref TimeData timeDate)
        {
            string[] notFormatTime = inputDate.Split(separators);
            ushort[] formatTime = new ushort[notFormatTime.Length];
            for (int i = 0; i < notFormatTime.Length; i++)
            {
                formatTime[i] = ushort.Parse(notFormatTime[i]);
            }
            timeDate.Month = formatTime[MonthPriority];
            timeDate.Day = formatTime[DayPriority];
            timeDate.Year = formatTime[YearPriority];
            timeDate.Hour = formatTime[HourPriority];
            timeDate.Minute = formatTime[MinutePriority];
            timeDate.Second = formatTime[SecondPriority];
        }

    }
}
