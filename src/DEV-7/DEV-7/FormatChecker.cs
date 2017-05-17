using System.Text.RegularExpressions;

namespace DEV_7
{
    public enum DatePriority
    {
        Month = 0,
        Day = 1,
        Year = 2,
        Hour = 3,
        Minute = 4,
        Second = 5
    }
    /// <summary>
    /// Check date format MM.dd.yyyy HH:mm:ss;
    /// </summary>
    class FormatChecker
    {
        public bool IsValidForm(string inputDate)
        {
             return Regex.Match(inputDate, @"\d{2}.\d{2}.\d{4}\s\d{2}:\d{2}:\d{2}").Success;
        }
    }
}
