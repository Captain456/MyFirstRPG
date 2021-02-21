/// <summary>
/// Defines the BaseNotificationClass base class.
/// </summary>

namespace Engine
{
    using System.ComponentModel;

    /// <summary>
    /// A base class for handling notifications.
    /// </summary>
    public class BaseNotificationClass : INotifyPropertyChanged
    {
        /// <summary>
        /// The event handler for when a property is changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Sends a notification that a property was changed.
        /// </summary>
        /// <param name="propertyName"></param>
        public virtual void OnPropertyChanged(string propertyName)
        {
            // If PropertyChanged is null, do nothing. Otherwise, invoke the event handler.
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
