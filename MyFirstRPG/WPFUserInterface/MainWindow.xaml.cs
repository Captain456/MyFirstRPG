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
        /// A test function that increases the amount of hit points on each button click and loops back to 0 if it exceeds the max hit points.
        /// </summary>
        /// <param name="sender">The sender of the request</param>
        /// <param name="routedEventArgs">Routed event arguments</param>
        private void ButtonBase_OnClick(object sender, RoutedEventArgs routedEventArgs)
        {
            this.gameSession.CurrentPlayer.HitPoints = (this.gameSession.CurrentPlayer.HitPoints + 1) % (this.gameSession.CurrentPlayer.MaximumHitPoints + 1);
            this.gameSession.CurrentPlayer.Level = this.gameSession.CurrentPlayer.Level + 1;
        }
    }
}
