using System;

namespace DEV_7
{
    /// <summary>
    /// Checkinput hours, minutes, seconds
    /// </summary>
    class TimeChecker
    {
        private const int MaxHour = 23;
        private const int MinHour = 0;

        private const int MaxMiniuteSecond = 59;
        private const int MinMinuteSecond = 0;

        /// <summary>
        /// Check is valid Time
        /// </summary>
        /// <param name="hour">hou</param>
        /// <param name="minute">minute</param>
        /// <param name="second">second</param>
        /// <returns>id VAlidTime</returns>
        public bool IsValidTime(ushort hour, ushort minute, ushort second)
        {
            return ((IsValidHour(hour) == false) || (IsValidMinute(minute) == false) || (IsValidSecond(second) == false)) ? false : true;
        }

        /// <summary>
        /// Check is valid hour
        /// </summary>
        /// <param name="hour">hour</param>
        /// <returns>is valid</returns>
        private bool IsValidHour(ushort hour)
        {
            bool isValid = true;
            if ((hour > MaxHour) || (hour < MinHour))
            {
                isValid = false;
                Console.WriteLine("Not valid Hour");
            }
            return isValid;
        }

        /// <summary>
        /// Check is valid minute
        /// </summary>
        /// <param name="minutes">minutes</param>
        /// <returns>is valid</returns>
        private bool IsValidMinute(int minutes)
        {
            bool isValid = true;
            if ((minutes > MaxMiniuteSecond) || (minutes < MinMinuteSecond))
            {
                isValid = false;
                Console.WriteLine("Not valid Minute");
            }
            return isValid;
        }

        /// <summary>
        /// Check is valid second
        /// </summary>
        /// <param name="second">second</param>
        /// <returns>is valid seconds</returns>
        private bool IsValidSecond(int second)
        {
            bool isValid = true;
            if ((second > MaxMiniuteSecond) || (second < MinMinuteSecond))
            {
                isValid = false;
                Console.WriteLine("Not valid Minute");
            }
            return isValid;
        }
    }
}
