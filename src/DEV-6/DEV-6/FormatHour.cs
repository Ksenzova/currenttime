using System;
using static DEV_6.Program;

namespace DEV_6
{
    /// <summary>
    /// Format hour h, hh, H, HH
    /// </summary>
    public class FormatHour:IFormat 
    {
        public string GetData(DateTime curDate, Format form)
        {
            int formatTime = 12;
            string hour = curDate.ToString();
            hour = hour.Split(' ')[1];
            hour = hour.Split(':')[0];

            // for hh  and h format
            double h12Format = double.Parse(hour);
            if (h12Format!=formatTime)
            {
                h12Format %= formatTime;
            }    
          
            switch (form)
            {
                case Format.H:
                    hour.TrimStart('0');
                    break;
                case Format.h:  
                    hour = h12Format.ToString();
                    break;
                case Format.hh:
                    hour = String.Empty;
                    hour = h12Format.ToString();
                    if (h12Format < 10)
                    {
                        hour = String.Concat('0', h12Format.ToString());
                    }
                    break;
                case Format.HH:
                    if(hour.Length==1)
                    {
                        hour = string.Concat("0", hour);
                    }
                    break;
                default:
                    hour = string.Empty;
                    break;
            }
            return hour;
        }
    }
}
