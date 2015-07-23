namespace MassEffect.Interfaces
{
    /// <summary>
    /// The CommandManager interface.
    /// </summary>
    public interface ICommandManager
    {
        /// <summary>
        /// Gets or sets the engine.
        /// </summary>
        IGameEngine Engine { get; set; }

        /// <summary>
        /// Process the appropriate command depending on the input.
        /// </summary>
        /// <param name="command">
        /// given command.
        /// </param>
        void ProcessCommand(string command);

        /// <summary>
        /// Predefine all acceptable commands.
        /// </summary>
        void SeedCommands();
    }
}