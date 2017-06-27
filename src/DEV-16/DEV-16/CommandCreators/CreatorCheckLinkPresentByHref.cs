using System;

namespace DEV_16.Commands
{
    /// <summary>
    /// Create Check Link Present By Href command
    /// </summary>
    class CreatorCheckLinkPresentByHref : CreatorCommand
    {
        Command command;
        public CreatorCheckLinkPresentByHref (CreatorCommand creator)
        {
            Successor = creator;
        }

        /// <summary>
        /// Create command if it matches resources.checkLinkPresentByHref
        /// </summary>
        /// <param name="strCommmand">input string formated command</param>
        /// <returns>command</returns>
        public override Command GetCommand(string strCommmand)
        {
            if (strCommmand.Contains(Resources.checkLinkPresentByHrefCommand))
            {
                command = new CheckLinkByHref(Parser.GetParam(strCommmand));
                command.commandString = strCommmand;
            }
            else if (Successor != null)
            {
                command = Successor.GetCommand(strCommmand);
            }
            return command;
        }
    }
}
