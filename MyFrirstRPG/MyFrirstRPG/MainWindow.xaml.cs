namespace WPFUserInterface
{
    using System.Windows;
    using Engine.ViewModels;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// The game session of the main window.
        /// </summary>
        private GameSession gameSession;

        /// <summary>
        /// Constructs a new <see cref="MainWindow"/> instance.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            this.gameSession = new GameSession();
            this.DataContext = this.gameSession;
        }

        /// <summary>
        /// Handles when the "North" button is clicked by moving the player north, if possible.
        /// </summary>
        /// <param name="sender">The sender of the routed event.</param>
        /// <param name="routedEventArgs">The arguments of the routed event.</param>
        private void OnClick_MoveNorth(object sender, RoutedEventArgs routedEventArgs)
        {
            this.gameSession.MoveNorth();
        }

        /// <summary>
        /// Handles when the "West" button is clicked by moving the player west, if possible.
        /// </summary>
        /// <param name="sender">The sender of the routed event.</param>
        /// <param name="routedEventArgs">The arguments of the routed event.</param>
        private void OnClick_MoveWest(object sender, RoutedEventArgs routedEventArgs)
        {
            this.gameSession.MoveWest();
        }

        /// <summary>
        /// Handles when the "East" button is clicked by moving the player east, if possible.
        /// </summary>
        /// <param name="sender">The sender of the routed event.</param>
        /// <param name="routedEventArgs">The arguments of the routed event.</param>
        private void OnClick_MoveEast(object sender, RoutedEventArgs routedEventArgs)
        {
            this.gameSession.MoveEast();
        }

        /// <summary>
        /// Handles when the "South" button is clicked by moving the player south, if possible.
        /// </summary>
        /// <param name="sender">The sender of the routed event.</param>
        /// <param name="routedEventArgs">The arguments of the routed event.</param>
        private void OnClick_MoveSouth(object sender, RoutedEventArgs routedEventArgs)
        {
            this.gameSession.MoveSouth();
        }
    }
}