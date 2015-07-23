namespace MassEffect.Interfaces
{
    using System.Collections.Generic;

    using MassEffect.Engine.Factories;
    using MassEffect.GameObjects;

    /// <summary>
    /// Game Engine, containing the necessary logic for the game.
    /// </summary>
    public interface IGameEngine
    {
        /// <summary>
        /// Gets the ship factory.
        /// </summary>
        ShipFactory ShipFactory { get; }

        /// <summary>
        /// Gets the enhancement factory.
        /// </summary>
        EnhancementFactory EnhancementFactory { get; }

        /// <summary>
        /// Gets the starships.
        /// </summary>
        IList<IStarship> Starships { get; }

        /// <summary>
        /// Gets the galaxy.
        /// </summary>
        Galaxy Galaxy { get; }

        /// <summary>
        /// Gets the command manager.
        /// </summary>
        ICommandManager CommandManager { get; }

        /// <summary>
        /// Gets or sets a value indicates stop or start the game.
        /// </summary>
        bool IsRunning { get; set; }

        /// <summary>
        /// Start the Engine.
        /// </summary>
        void Run();
    }
}