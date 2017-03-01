using System;
using static DEV_6.Program;

namespace DEV_6
{
    /// <summary>
    /// Format hour h, hh, H, HH
    /// </summary>
    class FormatHour:IFormat 
    {
        public string GetData(DateTime curDate, Format form)
        {
            int formatTime = 12;
            string hour = curDate.ToLongTimeString();
            hour = hour.Substring(0, 2);
            int h12Format = int.Parse(hour);
            h12Format %= formatTime;    // for hh  and h format
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
                    if (h12Format < 10)
                        hour = "0";
                    hour = String.Concat(hour, h12Format.ToString());
                    break;
                case Format.HH:
                    break;
                default:
                    hour = string.Empty;
                    break;
            }
            return hour;
        }
    }
}
