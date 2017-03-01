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

        public bool IsValidTime(ushort hour, ushort minute, ushort second)
        {
            bool isValid = true;
            if ((IsValidHour(hour) == false) || (IsValidMinitSecond(minute) == false) || (IsValidMinitSecond(second)==false))
            {
                isValid = false;
            }
            return isValid;
        }

        private bool IsValidHour(ushort hour)
        {
            bool isValid = true;
            isValid =((hour > MaxHour) || (hour < MinHour)) ? false : true;
            return isValid;
        }

        private bool IsValidMinitSecond(int minutes)
        {
            bool isValid = true;
            isValid = ((minutes > MaxMiniuteSecond) || (minutes < MaxMiniuteSecond)) ? false : true;
            return isValid;
        }
    }
}
