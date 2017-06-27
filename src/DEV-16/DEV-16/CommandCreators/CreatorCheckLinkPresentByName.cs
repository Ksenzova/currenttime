using DEV_16.Commands;

namespace DEV_16.CommandCreators
{
    /// <summary>
    /// Create Check Link Present By Name command
    /// </summary>
    class CreatorCheckLinkPresentByName : CreatorCommand
    {
        Command command;
        public CreatorCheckLinkPresentByName (CreatorCommand creator)
        {
            Successor = creator;
        }

        /// <summary>
        /// Create command if it matches resources.ckeckLinkPresentByName
        /// </summary>
        /// <param name="strCommmand">input commant</param>
        /// <returns>command</returns>
        public override Command GetCommand(string strCommmand)
        {
            if (strCommmand.Contains(Resources.checkLinkPresentByNameCommand))
            {
                command = new  CheckLinkPresentByName(Parser.GetParam(strCommmand));
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
