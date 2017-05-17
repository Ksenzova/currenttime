namespace DEV_7
{
    /// <summary>
    /// Parse input date and time 
    /// Fill stogage of date and time
    /// </summary>
    class DateParser
    {
        private char[] separators = { ':', '.', ' ' };

        public void ParseData(string inputDate, ref TimeData timeDate)
        {
            string[] notFormatTime = inputDate.Split(separators);
            ushort[] formatTime = new ushort[notFormatTime.Length];
            for (int i = 0; i < notFormatTime.Length; i++)
            {
                formatTime[i] = ushort.Parse(notFormatTime[i]);
            }

            timeDate.Month = formatTime[(int)DatePriority.Month];
            timeDate.Day = formatTime[(int)DatePriority.Day];
            timeDate.Year = formatTime[(int)DatePriority.Year];
            timeDate.Hour = formatTime[(int)DatePriority.Hour];
            timeDate.Minute = formatTime[(int)DatePriority.Minute];
            timeDate.Second = formatTime[(int)DatePriority.Second];
        }
    }
}
