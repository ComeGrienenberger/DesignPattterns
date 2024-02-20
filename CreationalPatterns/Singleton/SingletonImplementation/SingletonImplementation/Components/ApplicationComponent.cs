using Singleton.Model;
using SingletonImplementation.Messages;

namespace SingletonImplementation.Components
{
    /// <summary>
    /// A standard application component receiving and dispatching messages.
    /// </summary>
    public abstract class ApplicationComponent
    {
        /// <summary>
        /// Protected constructor used to subscribe to dispatcher.
        /// </summary>
        protected ApplicationComponent() 
        {
            MessageDispatcherSingleton.GetInstance().Subscribe(this);
        }

        /// <summary>
        /// Reacts to a message sent by other components.
        /// </summary>
        /// <param name="message"> The message sent by other components. </param>
        public abstract void ReactToMessage(Message message);

        /// <summary>
        /// Send a message to other components.
        /// </summary>
        public abstract void SendMessage();
    }
}
