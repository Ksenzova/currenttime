using System;

namespace DEV_7
{
    /// <summary>
    /// Check format  MM.dd.yyyy HH:mm:ss of input date and 
    /// Check valid values of input date and time
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input time and date in format: MM.dd.yyyy HH:mm:ss");
            string inputDate = Console.ReadLine();

            FormatChecker formatChecker = new FormatChecker();
            
            if (formatChecker.IsValidForm(inputDate))
            {
                // Create storage for time and data and fill it
                TimeData timeDate = new TimeData();
                DateParser dateParser = new DateParser();
                dateParser.ParseData(inputDate, ref timeDate);

                DateChecker dateChecher = new DateChecker();
                bool IsValidDate = dateChecher.IsValidDate(timeDate.Year, timeDate.Month, timeDate.Day);

                TimeChecker timeChecker = new TimeChecker();
                bool IsValidTime = timeChecker.IsValidTime(timeDate.Hour, timeDate.Minute, timeDate.Second);

                if ((IsValidDate == true) && (IsValidTime == true))
                {
                    Console.WriteLine("Input values of date and time are valid");
                }
            }
            else
            {
                Console.WriteLine("Format is incorrect");
            }     
            Console.ReadKey();
        }
    }
}
