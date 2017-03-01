using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_6
{
    /// <summary>
    /// Return year from 0 to 99
    /// </summary>
    class Timey : IFormat
    {
        public string GetData(DateTime curDate)
        {
            string date = curDate.ToString();
            string[] dateDev = date.Split('.', ' ');
            date = dateDev[2];
            date = date.Substring(2, 2);
            int year = int.Parse(date);
            return year.ToString();
        }
    }
}
