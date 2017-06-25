using System.Collections.Generic;
using System.IO;

namespace DEV_9
{
    /// <summary>
    /// Find value
    /// </summary>
    class FileReader
    {
        /// <summary>
        /// Find value in current section
        /// </summary>
        /// <param name="section">need section</param>
        /// <param name="key">need key</param>
        /// <param name="path">path of need file</param>
        /// <returns>Value</returns>
        public string GetValue(string section, string key, string path)
        {
            string value = string.Empty;
            List <string> needSection = GetSection(section, path);
            foreach (string s in needSection)
            {
                if (s.Split('=')[0] == key)
                {
                    value = s.Split('=')[1];
                }
            }
            return value;
        }

        /// <summary>
        /// Write items of need section
        /// </summary>
        /// <param name="section">need section</param>
        /// <param name="path">path of file</param>
        /// <returns>List of all items in need section</returns>
        private List<string> GetSection(string section, string path)
        {
            string curSection = string.Empty;
            List<string> needSection = new List<string>();
            foreach (string s in File.ReadAllLines(path))
            {

                if (s.Trim().StartsWith("["))
                {
                    curSection = s;
                }
                if (!s.Trim().StartsWith("[") && curSection == section)
                {
                    needSection.Add(s);
                }
            }
            return needSection;
        }
    }
}
