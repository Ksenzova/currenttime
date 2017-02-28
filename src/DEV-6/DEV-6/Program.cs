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

            string formateDate;
            formater.Form = new FormatHour();
            formateDate = formater.GetData(curDate, formate);
            if (formateDate != String.Empty)
            {
                Console.WriteLine(formateDate);
            }
            formater.Form = new FormatYear();
            formateDate = formater.GetData(curDate, formate);
            if (formateDate != String.Empty)
            {
                Console.WriteLine(formateDate);
            }
            formater.Form = new FormatDay();
            formateDate = formater.GetData(curDate, formate);
            if (formateDate != String.Empty)
            {
                Console.WriteLine(formateDate);
            }
            Console.ReadKey();
        }
    }
}
