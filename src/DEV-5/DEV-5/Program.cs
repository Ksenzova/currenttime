using System;
using System.Collections.Generic;

namespace DEV_5
{
    /// <summary>
    /// Find number of Juniors, Middles, Seniorss, Leads to team accoding input parametrs:
    /// all summ for project, amount of need work, choosing criterion
    /// Can choose max productivity , min cost, min number of more hightskilled worker than Junior
    /// </summary>
    class Program
    {
        /// <summary>
        /// new type for selection criterion
        /// </summary>
        public enum Criterion
        {
            maxPr,
            minCost,
            minHightSkillWorkers
        }
              
        static void Main(string[] args)
        {
            // staff formation
            List<Worker> staff = new List<Worker>();
            staff.Add(new Junior());
            staff.Add(new Middle());
            staff.Add(new Senior());
            staff.Add(new Lead());
            // Inputing parametrs 
            Console.WriteLine("Input all sum");
            int alluSum = int.Parse(Console.ReadLine());
            Console.WriteLine("Input all productivity");
            int allProductivity = int.Parse(Console.ReadLine());
            Console.WriteLine("Input criterion: maxProductivity,minCost,minHighSkillWorkers");
            Criterion criterion;
            try
            {
                criterion = (Criterion)Enum.Parse(typeof(Criterion), Console.ReadLine());
            }
            catch 
            { 
                criterion = Criterion.maxPr;
            }
            Dictionary<Worker, int> team = new Dictionary<Worker, int>();        
            // choose criterion
            switch(criterion)
            {
                case Criterion.maxPr:
                    MaxProductivity maxP = new MaxProductivity();
                    team = maxP.GetTeam(alluSum, allProductivity, staff);
                    break;
                case Criterion.minCost:
                    MinCosts minC = new MinCosts();
                    team = minC.GetTeam(alluSum, allProductivity, staff);
                    break;
                default:
                    MinHighSkillWorkers minW = new MinHighSkillWorkers();
                    team = minW.GetTeam(alluSum, allProductivity, staff);
                    break;
            }
            // Output results
            foreach (KeyValuePair<Worker, int> member in team)
            {
                Console.WriteLine("{0}   : {1}",member.Key.Experience, member.Value);
            }
             Console.ReadKey();
             
        }

    }
    }


          