namespace MassEffect.Interfaces
{
    /// <summary>
    /// Game Projectile.
    /// </summary>
    public interface IProjectile
    {
        /// <summary>
        /// Gets or sets the damage.
        /// </summary>
        int Damage { get; set; }

        /// <summary>
        /// The hit method apply projectiles effect on a ship.
        /// </summary>
        /// <param name="ship">
        /// IStarship
        /// </param>
        void Hit(IStarship ship);
    }
}