/// <summary>
/// This file defines the GameSession class.
/// </summary>

namespace Engine.ViewModels
{
    using System.ComponentModel;
    using Engine.Factories;
    using Engine.Models;

    /// <summary>
    /// A view model representing the game session which acts as a controlling layer between the view and the models.
    /// </summary>
    public class GameSession : BaseNotificationClass
    {
        /// <summary>
        /// The current location of the player in the game world.
        /// </summary>
        private Location currentLocation;

        /// <summary>
        /// Gets or sets the current <see cref="Player"/> of the game.
        /// </summary>
        public Player CurrentPlayer { get; set; }

        /// <summary>
        /// Gets or sets the current <see cref="World"/> of the game.
        /// </summary>
        public World CurrentWorld { get; set; }

        /// <summary>
        /// Gets or sets the current <see cref="Location"/> of the game.
        /// </summary>
        public Location CurrentLocation
        {
            get
            {
                return this.currentLocation;
            }
            set
            {
                this.currentLocation = value;
                this.OnPropertyChanged(nameof(CurrentLocation));
                this.OnPropertyChanged(nameof(HasLocationToNorth));
                this.OnPropertyChanged(nameof(HasLocationToWest));
                this.OnPropertyChanged(nameof(HasLocationToEast));
                this.OnPropertyChanged(nameof(HasLocationToSouth));
            }
        }

        /// <summary>
        /// Returns true if the current location has a non-null location to the north. Returns false otherwise.
        /// </summary>
        public bool HasLocationToNorth
        {
            get
            {
                return this.CurrentWorld.GetLocationAt(this.CurrentLocation.XCoordinate, this.CurrentLocation.YCoordinate + 1) != null;
            }
        }

        /// <summary>
        /// Returns true if the current location has a non-null location to the west. Returns false otherwise.
        /// </summary>
        public bool HasLocationToWest
        {
            get
            {
                return this.CurrentWorld.GetLocationAt(this.CurrentLocation.XCoordinate - 1, this.CurrentLocation.YCoordinate) != null;
            }
        }

        /// <summary>
        /// Returns true if the current location has a non-null location to the east. Returns false otherwise.
        /// </summary>
        public bool HasLocationToEast
        {
            get
            {
                return this.CurrentWorld.GetLocationAt(this.CurrentLocation.XCoordinate + 1, this.CurrentLocation.YCoordinate) != null;
            }
        }

        /// <summary>
        /// Returns true if the current location has a non-null location to the south. Returns false otherwise.
        /// </summary>
        public bool HasLocationToSouth
        {
            get
            {
                return this.CurrentWorld.GetLocationAt(this.CurrentLocation.XCoordinate, this.CurrentLocation.YCoordinate - 1) != null;
            }
        }

        /// <summary>
        /// Constructs a new <see cref="GameSession"/> instance.
        /// </summary>
        public GameSession()
        {
            this.CurrentPlayer = new Player("Some Call Me Tim", "Wizard");
            this.CurrentWorld = WorldFactory.CreateWorld();
            this.CurrentLocation = this.CurrentWorld.GetLocationAt(0, -1);
        }

        /// <summary>
        /// Moves the current location to the next location north, if possible.
        /// </summary>
        public void MoveNorth()
        {
            if (this.HasLocationToNorth)
            {
                this.CurrentLocation = this.CurrentWorld.GetLocationAt(this.CurrentLocation.XCoordinate, this.CurrentLocation.YCoordinate + 1);
            }
        }

        /// <summary>
        /// Moves the current location to the next location west, if possible.
        /// </summary>
        public void MoveWest()
        {
            if (this.HasLocationToWest)
            {
                this.CurrentLocation = this.CurrentWorld.GetLocationAt(this.CurrentLocation.XCoordinate - 1, this.CurrentLocation.YCoordinate);
            }
        }

        /// <summary>
        /// Moves the current location to the next location east, if possible.
        /// </summary>
        public void MoveEast()
        {
            if (this.HasLocationToEast)
            {
                this.CurrentLocation = this.CurrentWorld.GetLocationAt(this.CurrentLocation.XCoordinate + 1, this.CurrentLocation.YCoordinate);
            }
        }

        /// <summary>
        /// Moves the current location to the next location south, if possible.
        /// </summary>
        public void MoveSouth()
        {
            if (this.HasLocationToSouth)
            {
                this.CurrentLocation = this.CurrentWorld.GetLocationAt(this.CurrentLocation.XCoordinate, this.CurrentLocation.YCoordinate - 1);
            }
        }
    }
}