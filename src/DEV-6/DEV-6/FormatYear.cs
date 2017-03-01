using System;
using static DEV_6.Program;

namespace DEV_6
{
    class FormatYear :IFormat
    {
        public string GetData(DateTime curDate, Format form)
        {
            int year;
            string date = curDate.ToString();
            string[] dateDev = date.Split('.', ' ');
            switch (form)
            {
                case Program.Format.y:
                    date = dateDev[2];
                    date = date.Substring(2, 2);
                    year = int.Parse(date);
                    date = year.ToString();
                    break;
                case Program.Format.yy:
                    date = dateDev[2];
                    date = date.Substring(2, 2);
                    break;
                case Program.Format.yyy:
                    date = dateDev[2];
                    date.TrimStart('0');
                    break;
                case Program.Format.yyyy:
                    date = dateDev[2];
                    break;
                default:
                    date = string.Empty;
                    break;
            }
            return date;
        }     
    }
}
