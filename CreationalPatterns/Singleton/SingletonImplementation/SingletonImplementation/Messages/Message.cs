using SingletonImplementation.Components;

namespace SingletonImplementation.Messages
{
    /// <summary>
    /// Simple message.
    /// </summary>
    public class Message
    {
        /// <summary>
        /// Message content.
        /// </summary>
        public string Content { get; set; }

        public ApplicationComponent Sender { get; set; }

        /// <summary>
        /// Simple constructor.
        /// </summary>
        /// <param name="content"> Message's content. </param>
        public Message(string content, ApplicationComponent sender)
        {
            Content = content;
            Sender = sender;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return Content;
        }
    }
}
