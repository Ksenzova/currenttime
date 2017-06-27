namespace DEV_16
{
    /// <summary>
    /// Abstract command
    /// </summary>
    abstract class Command
    {
        /// <summary>
        /// string formed command
        /// </summary>
        public string commandString { get; set; }

        /// <summary>
        /// Execute command
        /// </summary>
        public abstract void Execute();
    }
}
