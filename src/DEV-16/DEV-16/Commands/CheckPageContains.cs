using System.Diagnostics;

namespace DEV_16.Commands
{
    /// <summary>
    /// CheckPageContains command
    /// </summary>
    class CheckPageContains : Command
    {
        string text;
        public CheckPageContains(string text)
        {
            this.text = text;
        }

        /// <summary>
        /// Realisation of checkPageConatins command
        /// </summary>
        public override void Execute()
        {
            Provider.provider.CheckContains(text);
        }
    }
}
