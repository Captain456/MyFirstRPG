/// <summary>
/// Defines the Weapon class.
/// </summary>

namespace Engine.Models
{
    /// <summary>
    /// Represents a weapon item that the player can use to deal damage to enemies.
    /// </summary>
    public class Weapon : GameItem
    {
        /// <summary>
        /// The minimum amount of damage that the weapon can deal to an enemy.
        /// </summary>
        public int MinimumDamage { get; set; }

        /// <summary>
        /// The maximum amount of damage that the weapon can deal to an enemy.
        /// </summary>
        public int MaximumDamage { get; set; }

        /// <summary>
        /// Constructs a new <see cref="Weapon"/> instance.
        /// </summary>
        /// <param name="itemTypeID">The ID of the item's object type.</param>
        /// <param name="name">The name of the item.</param>
        /// <param name="description">The description of the item.</param>
        /// <param name="price">The price of the item from the shop.</param>
        /// <param name="minimumDamage">The minimum amount of damage that the weapon can deal to an enemy.</param>
        /// <param name="maximumDamage">The maximum amount of damage that the weapon can deal to an enemy.</param>
        public Weapon(int itemTypeID, string name, string description, int price, int minimumDamage, int maximumDamage)
            : base(itemTypeID, name, description, price)
        {
            this.MinimumDamage = minimumDamage;
            this.MaximumDamage = maximumDamage;
        }

        /// <summary>
        /// Creates a copy of this <see cref="Weapon"/> object.
        /// </summary>
        /// <returns>The clone of the <see cref="Weapon"/> object.</returns>
        public new Weapon Clone()
        {
            return new Weapon(this.ItemTypeID, this.Name, this.Description, this.Price, this.MinimumDamage, this.MaximumDamage);
        }
    }
}
