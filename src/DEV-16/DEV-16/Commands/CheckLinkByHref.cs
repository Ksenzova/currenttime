namespace DEV_16.Commands
{
    /// <summary>
    /// CheckLinkByHref command
    /// </summary>
    class CheckLinkByHref : Command
    {
        string href;
        public CheckLinkByHref(string href)
        {
            this.href = href;
        }

        /// <summary>
        /// Realisation of CheckLinkByHref command
        /// </summary>
        public override void Execute()
        {
            Provider.provider.CheckLinkPresenrByHref(href);
        }
    }
}
