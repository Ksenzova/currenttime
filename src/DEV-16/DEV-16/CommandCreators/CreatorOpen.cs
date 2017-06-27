using System;
using System.Diagnostics;

namespace DEV_16.Commands
{
    /// <summary>
    /// Create Open command
    /// </summary>
    class CreatorOpen : CreatorCommand
    {
        Command command;
        public CreatorOpen(CreatorCommand creator)
        {
            Successor = creator;
        }

        /// <summary>
        /// Create command to if strCommsnd match Resousces.opeen.Command
        /// </summary>
        /// <param name="strCommand">input strCommand</param>
        /// <returns>Command</returns>
        public override Command GetCommand(string strCommand)
        {
            if (strCommand.Contains(Resources.openCommand))
            {
                command = new OpenCommand(Parser.GetURL(strCommand),Parser.GetTime(strCommand));
                command.commandString = strCommand;
            }
            else if (Successor != null)
            {
                command = Successor.GetCommand(strCommand);
            }
            return command;
        }
    }
}