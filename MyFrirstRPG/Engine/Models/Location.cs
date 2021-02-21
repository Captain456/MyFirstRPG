/// <summary>
/// Defines the Location class.
/// </summary>

namespace Engine.Models
{
    /// <summary>
    /// Represents a location on the game map.
    /// </summary>
    public class Location
    {
        /// <summary>
        /// Gets or sets the name of the location.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the X-coordinate of the location.
        /// </summary>
        public int XCoordinate { get; set; }

        /// <summary>
        /// Gets or sets the Y-coordinate of the location.
        /// </summary>
        public int YCoordinate { get; set; }

        /// <summary>
        /// Gets or sets the description of the location.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the file path of the image that will be displayed when the player is at this location.
        /// </summary>
        public string ImagePath { get; set; }

        public Location(string name, int xCoordinate, int yCoordinate, string description, string imagePath)
        {
            this.Name = name;
            this.XCoordinate = xCoordinate;
            this.YCoordinate = yCoordinate;
            this.Description = description;
            this.ImagePath = imagePath;
        }
    }
}