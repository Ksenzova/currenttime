using System;
using System.Collections.Generic;


namespace DEV_4
{
    // Calculate number of bigrams,  
    class BigramAnalysis
    {
        private List<string> allBigrams = new List<string>();
        private List<float> numberOfAllBigrams = new List<float>();
        private float numaAllBigrams;
        private const int firstInitBigram = 1;
         
        /// <summary>
        /// Find Bigrams with ignoring " " 
        /// </summary>
        /// <param name="text">input text to find and calculate bigrams</param>
        public void CalculateBigrams(string text)
        {
            // Devide text into words
            string[] parseText = text.Split(' ');

            // Check letters for each word in input text
            foreach(string word in parseText)
            {
                int indexFirstLetter = 0;
                int indexSecondLetter = 1;

                while ((indexFirstLetter<word.Length-1) && (indexSecondLetter < word.Length))
                {
                    if(Char.IsLetter(word[indexFirstLetter]) != true)
                    {
                        indexFirstLetter++;
                        indexSecondLetter++;
                    }
                    else
                    {
                        if(Char.IsLetter(word[indexSecondLetter]) != true)
                        {
                            indexSecondLetter++;
                        }
                        else
                        {
                            string bigram = String.Concat(word[indexFirstLetter], word[indexSecondLetter]);
                            AddBigram(bigram);
                            indexFirstLetter++;
                            indexSecondLetter++;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Output Frequency of bigrams
        /// </summary>
        public void OutputBigramFrequency()
        {
            int index = 0;
            foreach(string bigram in allBigrams)
            {
                Console.WriteLine("'{0}' -> {1}",bigram,numberOfAllBigrams[index]/CalculateAllBigrams());
                index++;
            }
     
        }

        /// <summary>
        /// Calculate number of all bigrams
        /// </summary>
        /// <returns> number of all bigrams in input text </returns>
        private float CalculateAllBigrams()
        {
            float numaAllBigrams = 0;
            foreach (int num in numberOfAllBigrams)
            {
                numaAllBigrams += num;
            }
            return numaAllBigrams;

        }
        /// <summary>
        ///  Add new bigram to List and add first quantity to numberOfAllBigrams
        ///  Add quantity for existing bigrams
        /// </summary>
        /// <param name="bigram">string which contains new pair of letters</param>
        private void AddBigram(string bigram)
        {
            if (allBigrams.Contains(bigram))
            {
                numberOfAllBigrams[allBigrams.IndexOf(bigram)]++;
            }
            else
            {
                allBigrams.Add(bigram);
                numberOfAllBigrams.Add(firstInitBigram);   
            }
        }
    }
}
