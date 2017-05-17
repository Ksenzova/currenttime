using System;

namespace DEV_7
{
    /// <summary>
    /// Check input date: year, month, day
    /// </summary>
    class DateChecker
    {
        private int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private const int MaxYear = 9999;
        private const int MinYear = 1;

        private const int MinDay = 1;

        private const int MaxMonth= 12;
        private const int MinMonth = 1;

        /// <summary>
        /// Ckeck valid date
        /// </summary>
        /// <param name="year">year</param>
        /// <param name="month">month</param>
        /// <param name="day">day</param>
        /// <returns>ia valid date</returns>
        public bool IsValidDate(ushort year, ushort month, ushort day)
        {
            return ((IsValidDay(day, month, year) != true) || (IsValidMonth(month) != true) || (IsValidYear(year) != true))? false : true;
        }

        /// <summary>
        /// Check is valid month
        /// </summary>
        /// <param name="month">month to check</param>
        /// <returns>is valid</returns>
        private bool IsValidMonth(ushort month)
        {
            bool isValid = true;
            if ((month > MaxMonth) || (month < MinMonth))
            {
                isValid = false;
                Console.WriteLine("Not valid month");
            }    
            return isValid;
        }

        /// <summary>
        /// Check is valid year
        /// </summary>
        /// <param name="year">year</param>
        /// <returns>is valid year</returns>
        private bool IsValidYear(ushort year)
        {
            bool isValid = true;
            if ((year > MaxYear) || (year < MinYear))
            {
                Console.WriteLine("Not Valid year");
                isValid = false;
            }
            return isValid;
        }
        
        /// <summary>
        /// Check is valid day
        /// </summary>
        /// <param name="day">day</param>
        /// <param name="month">month</param>
        /// <param name="year">year</param>
        /// <returns>ia valid day</returns>
        private bool IsValidDay(ushort day, ushort month, ushort year)
        {
            bool isValid = true;
            if ((day < MinDay ) || (day > daysInMonth[month - 1]))
            {
                Console.WriteLine("Not Valid day");
                isValid = false;
            } 
            if((month == 2) && (IsLeapYear(year) == true) && (day == 29))
            {
                isValid = true;
            }      
            return isValid;
        }

        /// <summary>
        /// Check is it leap year
        /// </summary>
        /// <param name="year">year to check</param>
        /// <returns>is valid day</returns>
        private bool IsLeapYear(ushort year)
        {
            return (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0)) ? true : false;
        }
    }
}
