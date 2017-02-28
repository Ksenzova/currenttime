using System;
using static DEV_6.Program;

namespace DEV_6
{
    /// <summary>
    /// Return string witn current date
    /// </summary>
    class Def : IFormat
    {
        public string GetData(DateTime curDate, Format form)
        {
            string date = curDate.ToString();
            return date;
        }
    }
}
