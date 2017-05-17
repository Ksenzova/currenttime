using System;

namespace DEV_16.Commands
{
    /// <summary>
    /// OpenCommand command
    /// </summary>
    class OpenCommand : Command
    {
        string url;
        TimeSpan time;
        public OpenCommand(string url,TimeSpan time)
        {
            this.url = url;
            this.time = time;   
        }

        /// <summary>
        /// Realisation of Open Command
        /// </summary>
        public override void Execute()
        {
            Provider.provider.Open(url,time);
        }
    }
}
