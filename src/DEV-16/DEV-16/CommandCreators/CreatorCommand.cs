using System;

namespace DEV_16.Commands
{
    /// <summary>
    /// Create command
    /// </summary>
    abstract class CreatorCommand
    {
        /// <summary>
        /// Parser to indentify command
        /// </summary>
        public Parser Parser = new Parser();

        public CreatorCommand Successor { get; set; }
        public abstract Command GetCommand(string strCommand);
    }
}
