using Singleton.Model;
using SingletonImplementation.Messages;

namespace SingletonImplementation.Components
{
    public class SecondComponent : ApplicationComponent
    {
        public override void ReactToMessage(Message message)
        {
            if (ReferenceEquals(message.Sender, this)) return;
            Console.WriteLine("I have received a message.");
        }

        public override void SendMessage()
        {
            MessageDispatcherSingleton.GetInstance().SendMessage(new Message("I send a message", this));
        }
    }
}
