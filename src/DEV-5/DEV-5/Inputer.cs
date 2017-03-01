using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_5
{

    /// <summary>
    /// new type for selection criterion
    /// </summary>
    public enum Criterion
    {
        maxProduct,
        minCost,
        minHightSkillWorkers
    }

    /// <summary>
    /// Input and set default values if input params are wrong
    /// </summary>
    class Inputer
    {
        private const int DEF_SUM = 1000;
        private const int DEF_PRODUCTIVITY = 15;
        public int InputSum()
        {
            Console.WriteLine("Input all sum");
            int alluSum;
            try
            {
                alluSum = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Error input");
                alluSum = DEF_SUM;
                Console.WriteLine("All Sum = ",alluSum);
            }
            return alluSum;
        }
        public int InputProductivity()
        {
            Console.WriteLine("Input all productivity");
            int productivity;
            try
            {
                productivity = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Error input");
                productivity = DEF_PRODUCTIVITY;
                Console.WriteLine("All productivity= ", productivity);
            }
            return productivity;
        }

        public Criterion InputCriterion()
        {
            Console.WriteLine("Input criterion: maxProduct,minCost,minHighSkillWorkers");
            Criterion criterion;
            try
            {
                criterion = (Criterion)Enum.Parse(typeof(Criterion), Console.ReadLine());
            }
            catch
            {
                criterion = Criterion.minHightSkillWorkers;
                Console.WriteLine("Error. Set default criterion - ", criterion);
            }
            return criterion;
        }
    }     
}
