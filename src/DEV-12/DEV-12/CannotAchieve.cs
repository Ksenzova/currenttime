using System;

namespace DEV_12
{
    [Serializable]
    public class CannotAchieve : Exception
    {
        public CannotAchieve(string message) : base(message)
        {
        }   
    }
}