using DEV_16.Commands;
namespace DEV_16.CommandCreators
{
    /// <summary>
    /// Create Check Page Contains command
    /// </summary>
    class CreatorCheckPageContains : CreatorCommand
    {
        Command command;
        public CreatorCheckPageContains (CreatorCommand creator)
        {
            Successor = creator;
        }

        /// <summary>
        /// Create command to if it matches Resources.ChackPAigContainsCommand
        /// </summary>
        /// <param name="strCommmand">input command</param>
        /// <returns>formed command</returns>
        public override Command GetCommand(string strCommmand)
        {
            if (strCommmand.Contains(Resources.checkPageContainsCommand))
            {
                command = new  CheckPageContains(Parser.GetParam(strCommmand));
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
