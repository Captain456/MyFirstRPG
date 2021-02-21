/// <summary>
/// Defines the WorldFactory class.
/// </summary>

namespace Engine.Factories
{
    using Engine.Models;

    /// <summary>
    /// A factory class for creating a <see cref="World"/> instance.
    /// </summary>
    internal static class WorldFactory
    {
        internal static World CreateWorld()
        {
            World world = new World();

            world.AddLocation("Farmer's Field", -2, -1, "A giant field with rows of corn stretching off into the distance. Perfect for hiding.", "/Engine;component/Images/Locations/FarmFields.png");
            world.AddLocation("Farmer's House", -1, -1, "A small, plain shack that serves as the house of your neighbor, Farmer Ted.", "/Engine;component/Images/Locations/Farmhouse.png");
            world.AddLocation("Trading Shop", -1, 0, "Susan's shop where she sells all kinds of wares.", "/Engine;component/Images/Locations/Trader.png");
            world.AddLocation("Home", 0, -1, "It's your house. It's quite cozy.", "/Engine;component/Images/Locations/PlayerHouse.png");
            world.AddLocation("Town Square", 0, 0, "The center of town has a beautiful fountain.", "/Engine;component/Images/Locations/TownSquare.png");
            world.AddLocation("Herbalist's Hut", 0, 1, "A small hut with plants hung to dry outside.", "/Engine;component/Images/Locations/HerbalistsHut.png");
            world.AddLocation("Herbalist's Garden", 0, 2, "A small plot of land with many unfamiliar plants growing.", "/Engine;component/Images/Locations/HerbalistsGarden.png");
            world.AddLocation("Town Gate", 1, 0, "The main entrance to the town. A sturdy wooden door keeps out monsters that wander from the forest.", "/Engine;component/Images/Locations/TownGate.png");
            world.AddLocation("Spider Forest", 2, 0, "A dark, forbidding forest. The trees are covered in spider webs.", "/Engine;component/Images/Locations/SpiderForest.png");

            return world;
        }
    }
}
