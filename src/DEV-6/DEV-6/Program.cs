using System;

namespace DEV_6
{
    /// <summary>
    /// Return date in input format
    /// </summary>
    class Program
    {
        /// <summary>
        /// All types of format
        /// </summary>
        public enum Format
        {
            def,
            h,
            hh,
            H,
            HH,
            dddd,
            ddd,
            dd,
            d,
            yyyy,
            yyy,
            yy,
            y
        }
        static void Main(string[] args)
        {
            DateTime curDate = DateTime.Now;
            Console.WriteLine(curDate);
            Formater formater = new Formater(new Def());
            Format formate;
            try
            {
               formate = (Format)Enum.Parse(typeof(Format), Console.ReadLine());
            }
            catch
            {
                formate = Format.def;
            }
            
            switch(formate)
            {
                case Format.h:
                        formater.Form = new Timh();
                        break;
                case Format.hh:
                        formater.Form = new Timhh();
                        break;
                case Format.H:
                        formater.Form = new TimeH();
                        break;
                case Format.HH:
                        formater.Form = new TimeHH();
                        break;
                case Format.ddd:
                        formater.Form = new Timeddd();
                        break;
                case Format.dd:
                        formater.Form = new Timedd();
                        break;
                case Format.d:
                        formater.Form = new Timed();
                        break;
                case Format.dddd:
                        formater.Form = new Timedddd();
                        break;
                case Format.yyyy:
                        formater.Form = new Timeyyyy();
                        break;
                case Format.yyy:
                    formater.Form = new Timeyyy();
                    break;
                case Format.yy:
                    formater.Form = new Timeyy();
                    break;
                case Format.y:
                    formater.Form = new Timey();
                    break;
                default:
                    break;
            }

            string formateDate = formater.GetData(curDate);
            Console.WriteLine(formateDate); 
            Console.ReadKey();
        }
    }
}
