namespace MassEffect.Interfaces
{
    using System.Collections.Generic;

    using MassEffect.GameObjects.Enhancements;

    /// <summary>
    /// The Enhanceable interface.
    /// </summary>
    public interface IEnhanceable
    {
        /// <summary>
        /// Gets the enhancements.
        /// </summary>
        IEnumerable<Enhancement> Enhancements { get; }

        /// <summary>
        /// Inserts given enhancement to the starship's conteiner.
        /// </summary>
        /// <param name="enhancement">
        /// Enhancement.
        /// </param>
        void AddEnhancement(Enhancement enhancement);
    }
}