using System;

namespace DEV_4
{
    /// <summary>
    /// Make frequency text analysis: 
    /// Find frequency of bigrams( pair of letters)
    /// Find words with more than five letters
    /// Add new text to existing
    /// </summary>
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
                Console.WriteLine("More than five letters in the word in {0} words", counterWords.CalculateFiveLettersWords(text));
            }
        }
    }
}
