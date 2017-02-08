using System;

namespace Program
{
    class Selecter
    {
        /*
        * Find  from all options options that will be printed
        * */
        public static void Selecting(string[] options_all, int options_number)
        {
            Random rand = new Random();
            /*
             *  Check number of input options
             *  If less than two write all options
             *  If more than two use random to choose
             * */
            if (options_all.Length < options_number)
            {
                foreach (string s in options_all)
                    Console.Write(s + " ");  
            }
            else
            {
                for (int i = 0; i < options_number; i++)
                {
                    int selected;
                    selected = rand.Next(0, options_all.Length);
                    Console.WriteLine(options_all[selected]);
                }
            }
        }
    }   
}
