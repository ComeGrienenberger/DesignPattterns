using Singleton.Model;
using SingletonImplementation.Messages;

namespace SingletonImplementation.Components
{
    public class FirstComponent : ApplicationComponent
    {
        public override void ReactToMessage(Message message)
        {
            if (ReferenceEquals(message.Sender, this)) return;

            Console.WriteLine("First component reaction to message : " + message.ToString());
        }

        public override void SendMessage()
        {
            MessageDispatcherSingleton.GetInstance().SendMessage(new Message("First component sending message.", this));
        }
    }
}
