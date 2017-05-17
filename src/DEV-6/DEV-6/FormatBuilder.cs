using System;
using DEV_6;
using static DEV_6.Program;
using System.Collections.Generic;

namespace DEV_11
{
    /// <summary>
    /// Sum formated date with separators into one string
    /// </summary>
    class FormatBuilder
    {
        public string BuildFormat(List<Format> formats,List<char>separators, DateTime curDate)
        {
            string formatedDate = string.Empty;
            string date;
            for (int i = 0; i< formats.Count; i++)
            {
                date = string.Empty;
                Formater formater = new Formater(new FormatHour());
                date += formater.GetData(curDate, formats[i]);
                formater.Form = new FormatYear();
                date += formater.GetData(curDate, formats[i]);
                formater.Form = new FormatDay();
                date += formater.GetData(curDate, formats[i]);
                formater.Form = new FormatMonth();
                date += formater.GetData(curDate, formats[i]);
                if (date != string.Empty)
                {
                    formatedDate += date;
                    if(i!=formats.Count-1)
                    {
                        formatedDate += separators[i];
                    }
                }
            }
            return formatedDate;
        }
    }
}
