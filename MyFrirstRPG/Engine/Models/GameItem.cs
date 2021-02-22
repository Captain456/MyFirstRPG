/// <summary>
/// Defines the GameItem class.
/// </summary>

namespace Engine.Models
{
    /// <summary>
    /// Represents an item that the player can have in their inventory.
    /// </summary>
    public class GameItem
    {
        /// <summary>
        /// The ID of the item's object type.
        /// </summary>
        public int ItemTypeID { get; set; }

        /// <summary>
        /// The name of the item.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The description of the item.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The price of the item from the shop.
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// Constructs a new <see cref="GameItem"/> instance.
        /// </summary>
        /// <param name="itemTypeID">The ID of the item's object type.</param>
        /// <param name="name">The name of the item.</param>
        /// <param name="description">The description of the item.</param>
        /// <param name="price">The price of the item from the shop.</param>
        public GameItem(int itemTypeID, string name, string description, int price)
        {
            this.ItemTypeID = itemTypeID;
            this.Name = name;
            this.Description = description;
            this.Price = price;
        }

        /// <summary>
        /// Creates a copy of this <see cref="GameItem"/> object.
        /// </summary>
        /// <returns>The clone of the <see cref="GameItem"/> object.</returns>
        public GameItem Clone()
        {
            return new GameItem(this.ItemTypeID, this.Name, this.Description, this.Price);
        }
    }
}
