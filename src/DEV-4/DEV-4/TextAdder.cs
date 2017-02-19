using System;

namespace DEV_4
{
    /// <summary>
    ///  Add new text to existing
    /// </summary> 
    class TextAdder
    {
        private string addedText;
        /// <summary>
        /// Add new text to exixting
        /// </summary>
        /// <param name="previous"> before input text</param>
        /// <returns> new text</returns>
        public string AddAdditionalText (ref string previous)
        {
            addedText = Console.ReadLine();
            previous = previous.Insert(previous.Length, " ");
            previous = previous.Insert(previous.Length,addedText);
            previous.ToLower();
            return addedText;
        }    
    }
}
