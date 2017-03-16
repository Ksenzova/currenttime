using System;
using static DEV_6.Program;

namespace DEV_6
{
    /// <summary>
    /// Format day formats d dd ddd dddd
    /// </summary>
    public class FormatDay:IFormat
    { 
        public string GetData(DateTime curDate, Format form)
        {
            string date = curDate.ToString();
            date = date.Substring(0, 2);
            string weekDay = curDate.DayOfWeek.ToString();    
            string year = String.Empty;
            switch (form)
            {
                case Format.d:
                        date = curDate.ToString().Split(' ')[0];
                        break;
                case Program.Format.dd:
                        date.TrimStart('0');
                        break;
                case Program.Format.ddd:
                        date = weekDay.Substring(0, 3);
                        break;
                case Program.Format.dddd:
                        date = weekDay;
                        break;
                default:
                        date = string.Empty;
                        break;
            }
            return date;
        }
    }
}
