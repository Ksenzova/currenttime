using System;

namespace DEV_16
{
    /// <summary>
    /// Contaons test results
    /// </summary>
    struct ResultTest
    {
        public bool IsPass { get; set; }
        string command;
        public TimeSpan time { get; set; }
        public ResultTest(bool isPass, string command, TimeSpan time)
        {
            this.IsPass = isPass;
            this.command = command;
            this.time = time;
        }

        /// <summary>
        /// Convert result to need format
        /// </summary>
        /// <returns>formated result</returns>
        public override string ToString()
        {
            return string.Concat(IsPass?'+':'!', "  [", command, "]  ", time.Milliseconds);
        }
    }
}
