/// <summary>
/// This file defines the GameSession class.
/// </summary>

namespace Engine.ViewModels
{
    using Engine.Models;

    /// <summary>
    /// A view model representing the game session which acts as a controlling layer between the view and the models.
    /// </summary>
    public class GameSession
    {
        /// <summary>
        /// Gets or sets the current <see cref="Player"/> of the game.
        /// </summary>
        public Player CurrentPlayer { get; set; }

        /// <summary>
        /// Gets or sets the current <see cref="Location"/> of the game.
        /// </summary>
        public Location CurrentLocation { get; set; }

        /// <summary>
        /// Constructs a new <see cref="GameSession"/> instance.
        /// </summary>
        public GameSession()
        {
            this.CurrentPlayer = new Player("Some Call Me Tim", "Wizard");
            this.CurrentLocation = new Location("Home", 0, -1, "It's your house. It's quite cozy.", "/Engine;component/Images/Locations/PlayerHouse.png");
        }
    }
}