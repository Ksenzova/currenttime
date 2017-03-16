using DEV_6;
using System;
using static DEV_6.Program;

namespace DEV_11
{
    /// <summary>
    /// Format month MM MMM MMMM
    /// </summary>
    public class FormatMonth : IFormat
    {
        private string[] months ={"January","February", "March","April","May","June","July","August","September","October","November","December"};
        public string GetData(DateTime curDate, Format form)
        {
            string date = curDate.ToString();
            string month = date.Split('.')[1];
            switch (form)
            {
                case Format.MM:
                    date = month;
                    break;
                case Format.MMM:
                    date = months[int.Parse(month)-1];
                    date = date.Substring(0, 3);
                    break;
                case Format.MMMM:
                    date = months[int.Parse(month)-1];
                    break;
                default:
                    date = string.Empty;
                    break;
            }
            return date;
        }
    }
}
