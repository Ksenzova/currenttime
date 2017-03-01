namespace DEV_5
{
    /// <summary>
    /// Woker pattern
    /// </summary>
    public class Worker
    {
        protected int salary;
        protected int productivity;
        protected string experience;
        public int Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }
        public int Productivity
        {
            get
            {
                return productivity;
            }
            set
            {
                productivity = value;
            }
        }

        public string Experience
        {
            get
            {
                return experience;
            }
            set
            {
                experience= value;
            }
        }
    }
}
