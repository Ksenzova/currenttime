using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DEV_6.Program;

namespace DEV_6
{
  class FormatDay:IFormat
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
