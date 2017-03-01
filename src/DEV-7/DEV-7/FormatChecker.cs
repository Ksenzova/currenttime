namespace DEV_7
{
    /// <summary>
    /// Check date format MM.dd.yyyy HH:mm:ss;
    /// </summary>
    class FormatChecker
    {
        private string formatSeparators = ".. ::";

        public bool IsValidForm(string inputDate)
        {
            bool isValid = true;
            inputDate.Trim(' ');
            string separators = string.Empty;

            foreach (char symbol in inputDate)
            {
                if (!char.IsDigit(symbol))
                {
                    separators = string.Concat(separators, symbol);
                }
            }

            if (string.Compare(formatSeparators, separators) != 0)
            {
                isValid = false;
            }
            return isValid;
        }
    }
}
