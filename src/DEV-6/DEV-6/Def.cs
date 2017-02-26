using System;

namespace DEV_6
{
    class Def : IFormat
    {
        public string GetData(DateTime curDate)
        {
            string date = curDate.ToString();
            return date;
        }
    }
}
