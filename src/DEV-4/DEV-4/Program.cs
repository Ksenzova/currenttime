using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_4
{
    class Program
    {

        static void Main(string[] args)
        {

            string text = "";
            TextAdder textAdder = new TextAdder();
            BigramAnalysis analysis = new BigramAnalysis();
            WordsCounter counterWords = new WordsCounter();
            while(Console.ReadKey().Key != ConsoleKey.Escape)
            {
                Console.Clear();
                analysis.CalculateBigrams(textAdder.AddAdditionalText(ref text));
                Console.WriteLine(text);
                analysis.OutputBigramFrequency();
                Console.WriteLine("More than five letters in the word in {0} words", counterWords.CalFiveLLettersWords(text));
            }
        }
    }
}
