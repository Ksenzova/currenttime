using System;

namespace DEV_16
{
    /// <summary>
    /// Parse parameters of input command
    /// </summary>
    class Parser
    {
        /// <summary>
        /// Get URL to open command
        /// </summary>
        /// <param name="strCommand">input command</param>
        /// <returns>url</returns>
        public string GetURL(string strCommand)
        {
            strCommand = strCommand.Substring(strCommand.IndexOf(" "));
            strCommand = strCommand.Trim(' ');
            return  strCommand.Split(' ')[0].Trim('"');
        }

        /// <summary>
        /// Get time to open command
        /// </summary>
        /// <param name="strCommand">input command</param>
        /// <returns>time to open</returns>
        public TimeSpan GetTime(string strCommand)
        {
            strCommand = strCommand.Split(' ')[strCommand.Split(' ').Length-1];
            return TimeSpan.Parse(strCommand.Trim('"'));
         }

        /// <summary>
        /// Get paramtrs of command
        /// </summary>
        /// <param name="strCommand">input command</param>
        /// <returns>parameter</returns>
        public string GetParam(string strCommand)
        {
            return strCommand.Trim('"').Split('"')[1].Trim('"');
        }
    }
}
