
using System.Collections.Generic;

namespace DEV_5
{
    /// <summary>
    /// Patern fordifferent kinds of criterions
    /// </summary>
    abstract class ICriterion
    {
        protected int realProductivity = 0;
        protected int realSum = 0;
        public int RealSum
        {
            get
            {
                return realSum;
            }
        }
        public int RealProductuvity
        {
            get
            {
                return realProductivity;
            }
        }
        public void GetTeam(int allSum, int productivity, List<Worker> staff) { }
    }
}
