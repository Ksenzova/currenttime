using System;
using System.Collections.Generic;

namespace DEV_5
{
    /// <summary>
    /// Print alll members of team
    /// </summary>
    class Printer
    {
        public  void Output(Dictionary<Worker, int> team)
        {
            foreach (KeyValuePair<Worker, int> member in team)
            {
                Console.WriteLine("{0}   : {1}", member.Key.Experience, member.Value);
            }
        }
    }
}
