using SingletonImplementation.Components;
using SingletonImplementation.Messages;

namespace Singleton.Model
{
    /// <summary>
    /// Message dispatcher singleton.
    /// </summary>
    public class MessageDispatcherSingleton
    {
        /// <summary>
        /// Unique static nullable message dispatcher :) .
        /// </summary>
        private static MessageDispatcherSingleton? uniqueMessageDispatcher { get; set; }

        /// <summary>
        /// Components that are listening to other components.
        /// </summary>
        private List<ApplicationComponent> listeners;

        /// <summary>
        /// Protected constructor.
        /// </summary>
        protected MessageDispatcherSingleton()
        {
            listeners = new List<ApplicationComponent>();
        }

        /// <summary>
        /// Method to return the single instance of the message disspatcher.
        /// </summary>
        /// <returns> This class's instance. </returns>
        public static MessageDispatcherSingleton GetInstance()
        {
            if(uniqueMessageDispatcher is null)
            {
                uniqueMessageDispatcher = new MessageDispatcherSingleton();
            }

            return uniqueMessageDispatcher;
        }

        /// <summary>
        /// Sends a message to the listeners.
        /// </summary>
        /// <param name="message"> The message to send. </param>
        public void SendMessage(Message message)
        {
            foreach(var listener in listeners)
            {
                listener.ReactToMessage(message);
            }
        }

        /// <summary>
        /// Method used by components to subscribe to the dispatcher.
        /// </summary>
        /// <param name="component"> Component that wants to subscribe. </param>
        public void Subscribe(ApplicationComponent component)
        {
            listeners.Add(component);
        }

        /// <summary>
        /// Method used by components to unsubscrbe from the dispatcher.
        /// </summary>
        /// <param name="component"> Component that wants to unsubscribe. </param>
        public void Unsubscribe(ApplicationComponent component)
        {
            listeners.Remove(component);
        }
    }
}
