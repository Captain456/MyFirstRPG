/// <summary>
/// Defines the World class.
/// </summary>

namespace Engine.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// Represents the world of the game and tracks where locations are in relation to each other.
    /// </summary>
    public class World
    {
        /// <summary>
        /// Contains all of the locations in the world.
        /// </summary>
        private List<Location> locations = new List<Location>();

        /// <summary>
        /// Adds a new <see cref="Location"/> to the list of locations.
        /// </summary>
        internal void AddLocation(string name, int xCoordinate, int yCoordinate, string description, string imagePath)
        {
            Location location = new Location(name, xCoordinate, yCoordinate, description, imagePath);

            this.locations.Add(location);
        }

        public Location GetLocationAt(int xCoordinate, int yCoordinate)
        {
            foreach (Location location in this.locations)
            {
                if (location.XCoordinate == xCoordinate && location.YCoordinate == yCoordinate)
                {
                    return location;
                }
            }

            return null;
        }
    }
}
