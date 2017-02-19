namespace DEV_4
{   
    /// <summary>
    ///  Find number of words with more than 5 letters
    /// </summary>
    class WordsCounter
    {
        private string[] words;
        private int wordsMorefiveLetters;
        private char[] separators = new char[] { ',', '.', '!', '?' , ' ','_'};
       
        /// <summary>
        /// Calculate number of words with more than 5 words
        /// </summary>
        /// <param name="text"> input text</param>
        /// <returns>number of words with more than 5 Letters</returns>
        public int CalculateFiveLettersWords(string text)
        {  
            words = text.Split(separators);
            foreach(string word in words)
            {
                if (word.Length > 5)
                {
                    wordsMorefiveLetters++;
                }            
            }
            return wordsMorefiveLetters;
        }      
    }
}
