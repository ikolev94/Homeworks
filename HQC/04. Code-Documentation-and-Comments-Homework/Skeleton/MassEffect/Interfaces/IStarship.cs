namespace MassEffect.Interfaces
{
    using MassEffect.GameObjects.Locations;

    /// <summary>
    /// Game Starship.
    /// </summary>
    public interface IStarship : IEnhanceable
    {
        /// <summary>
        /// Gets or sets starship name.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets starship health.
        /// </summary>
        int Health { get; set; }

        /// <summary>
        /// Gets or sets starship shields.
        /// </summary>
        int Shields { get; set; }

        /// <summary>
        /// Gets or sets starship damage.
        /// </summary>
        int Damage { get; set; }

        /// <summary>
        /// Gets or sets starship fuel.
        /// </summary>
        double Fuel { get; set; }

        /// <summary>
        /// Gets or sets starship location.
        /// </summary>
        StarSystem Location { get; set; }

        /// <summary>
        /// Makes the appropriate projectile depending on the starship.
        /// </summary>
        /// <returns>
        /// IProjectile<see cref="IProjectile"/>.
        /// </returns>
        IProjectile ProduceAttack();

        /// <summary>
        /// Make starhip respond to attack depending of his type.
        /// </summary>
        /// <param name="attack">
        /// The attack.
        /// </param>
        void RespondToAttack(IProjectile attack);
    }
}