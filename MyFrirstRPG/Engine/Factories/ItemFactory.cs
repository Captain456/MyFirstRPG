/// <summary>
/// Defines the ItemFactory class.
/// </summary>

namespace Engine.Factories
{
    using System.Collections.Generic;
    using System.Linq;
    using Engine.Models;

    /// <summary>
    /// Used to create an instance of the <see cref="GameItem"/> class.
    /// </summary>
    public static class ItemFactory
    {
        /// <summary>
        /// A list that contains all standard <see cref="GameItem"/> objects known to the game.
        /// </summary>
        private static List<GameItem> standardGameItems;
        
        /// <summary>
        /// A static constructor equivalent. This function will run during the first time any call to this class is made. This function populates the list of game items.
        /// </summary>
        static ItemFactory()
        {
            standardGameItems = new List<GameItem>();

            standardGameItems.Add(new Weapon(1001, "Pointy Stick", "A sharpened branch. Try not to poke your own eye out!", 1, 1, 2));
            standardGameItems.Add(new Weapon(1002, "Rusty Sword", "An old sword that hasn't seen use for years. Let's hope that you're immune to tetanus.", 5, 1, 3));
        }

        public static GameItem CreateGameItem(int itemTypeID)
        {
            return standardGameItems.FirstOrDefault(item => item.ItemTypeID == itemTypeID)?.Clone();
        }
    }
}
