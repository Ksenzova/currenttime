using System.Collections.Generic;
using System.Linq;

namespace DEV_5
{
    /// <summary>
    /// Find members to team from staff to get cheaper result
    /// Productivity is fixed is fixed
    /// </summary>
    class MinCosts : ICriterion
    {
        public Dictionary<Worker, int> GetTeam(int allSum, int productivity, List<Worker> staff)
        {
            // sort staff in ascending order of salary
            var sortedStaff = from u in staff
                              orderby u.Salary
                              select u;

            realProductivity = 0;
            realSum = 0;
            Dictionary<Worker, int> team = new Dictionary<Worker, int>();
            foreach (Worker worker in sortedStaff)
            {
                while (allSum - worker.Salary > 0)
                {
                    if (team.ContainsKey(worker))
                    {
                        team[worker] += 1;
                    }
                    else
                    {
                        team.Add(worker, 1);
                    }
                    realProductivity += worker.Productivity;
                    realSum += worker.Salary;
                    allSum -= worker.Salary;
                }
            }
            return team;
        }

    }
}
