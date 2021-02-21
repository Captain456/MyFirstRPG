/// <summary>
/// This file defines the Player class.
/// </summary>
/// 
namespace Engine.Models
{
    using System.ComponentModel;

    /// <summary>
    /// Represents the player of the RPG game.
    /// </summary>
    public class Player : BaseNotificationClass
    {
        /// <summary>
        /// The name of the player.
        /// </summary>
        private string name;

        /// <summary>
        /// The character class of the player.
        /// </summary>
        private string characterClass;

        /// <summary>
        /// The current amount of hit points of the player.
        /// </summary>
        private int hitPoints;

        /// <summary>
        /// The maximum amount of hit points that the player can have.
        /// </summary>
        private int maximumHitPoints;

        /// <summary>
        /// The current amount of experience points of the player.
        /// </summary>
        private int experiencePoints;

        /// <summary>
        /// The current level of the player.
        /// </summary>
        private int level;

        /// <summary>
        /// The current amount of gold that the player has.
        /// </summary>
        private int gold;

        /// <summary>
        /// Gets or sets the name of the player.
        /// </summary>
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
                this.OnPropertyChanged(nameof(this.Name));
            }
        }

        /// <summary>
        /// Gets or sets the character class (or role) of the player.
        /// </summary>
        public string CharacterClass
        {
            get
            {
                return this.characterClass;
            }
            set
            {
                this.characterClass = value;
                this.OnPropertyChanged(nameof(this.CharacterClass));
            }
        }

        /// <summary>
        /// Gets or sets the hit points (i.e. health) of the player.
        /// </summary>
        public int HitPoints
        {
            get
            {
                return this.hitPoints;
            }
            set
            {
                this.hitPoints = value;
                this.OnPropertyChanged(nameof(this.HitPoints));
                this.OnPropertyChanged(nameof(this.HealthString));
            }
        }

        /// <summary>
        /// Gets or sets the maximum number of hit points (i.e. health) of the player.
        /// </summary>
        public int MaximumHitPoints
        {
            get
            {
                return this.maximumHitPoints;
            }
            set
            {
                this.maximumHitPoints = value;
                this.OnPropertyChanged(nameof(this.MaximumHitPoints));
                this.OnPropertyChanged(nameof(this.HealthString));
            }
        }

        /// <summary>
        /// Gets a string representing the amount of health that the player has.
        /// </summary>
        public string HealthString
        {
            get
            {
                return string.Format("{0}/{1}", this.HitPoints, this.MaximumHitPoints);
            }
        }

        /// <summary>
        /// Gets or sets the number of experience points of the player.
        /// </summary>
        public int ExperiencePoints
        {
            get
            {
                return this.experiencePoints;
            }
            set
            {
                this.experiencePoints = value;
                this.OnPropertyChanged(nameof(this.ExperiencePoints));
            }
        }

        /// <summary>
        /// Gets or sets the level of the player.
        /// </summary>
        public int Level
        {
            get
            {
                return this.level;
            }
            set
            {
                this.level = value;
                this.OnPropertyChanged(nameof(this.Level));
            }
        }

        /// <summary>
        /// Gets or sets the amount of gold that the player has.
        /// </summary>
        public int Gold
        {
            get
            {
                return this.gold;
            }
            set
            {
                this.gold = value;
                this.OnPropertyChanged(nameof(this.Gold));
            }
        }

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