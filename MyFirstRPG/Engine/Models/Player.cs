/// <summary>
/// This file defines the Player class.
/// </summary>

namespace Engine.Models
{
    /// <summary>
    /// Represents the player of the RPG game.
    /// </summary>
    public class Player
    {
        /// <summary>
        /// Gets or sets the name of the player.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets the character class (or role) of the player.
        /// </summary>
        string CharacterClass { get; set; }

        /// <summary>
        /// Gets or sets the hit points (i.e. health) of the player.
        /// </summary>
        int HitPoints { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of hit points (i.e. health) of the player.
        /// </summary>
        int MaximumHitPoints { get; set; }

        /// <summary>
        /// Gets or sets the number of experience points of the player.
        /// </summary>
        int ExperiencePoints { get; set; }

        /// <summary>
        /// Gets or sets the level of the player.
        /// </summary>
        int Level { get; set; }

        /// <summary>
        /// Gets or sets the amount of gold that the player has.
        /// </summary>
        int Gold { get; set; }

        /// <summary>
        /// Constructs a new instance of a <see cref="Player"/>.
        /// </summary>
        /// <param name="name">The name of the player.</param>
        /// <param name="characterClass">The character class or role of the player.</param>
        public Player(string name, string characterClass)
        {
            this.Name = name;
            this.CharacterClass = characterClass;
            this.MaximumHitPoints = 10;
            this.HitPoints = 10;
            this.ExperiencePoints = 0;
            this.Level = 1;
            this.Gold = 0;
        }
    }
}
