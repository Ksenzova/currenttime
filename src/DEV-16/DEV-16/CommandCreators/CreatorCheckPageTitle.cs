using DEV_16.Commands;

namespace DEV_16.CommandCreators
{
    /// <summary>
    /// Create Check Page Title command
    /// </summary>
    class CreatorCheckPageTitle : CreatorCommand
    {
        Command command;
        public CreatorCheckPageTitle (CreatorCommand creator)
        {
            Successor = creator;
        }

        /// <summary>
        /// Create command if it match Resources.checkPaheTitleCommand
        /// </summary>
        /// <param name="strCommmand">input command</param>
        /// <returns></returns>
        public override Command GetCommand(string strCommmand)
        {
            if (strCommmand.Contains(Resources.checkPageTitleCommand))
            {
                command = new CheckPageTitle(Parser.GetParam(strCommmand));
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
