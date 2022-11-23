namespace QProject.Base.Classes.Mailing
{
    public class MailMessage
    {
        public string Receiver { get; set; } = string.Empty;
        public virtual string? Subject { get; set; }
        public virtual string? Text { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MailMessage"/> class.
        /// </summary>
        /// <param name="receiver">The receiver.</param>
        public MailMessage(string receiver) 
        { 
            Receiver = receiver;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MailMessage"/> class.
        /// </summary>
        /// <param name="subject">The subject.</param>
        /// <param name="text">The text.</param>
        public MailMessage(string receiver, string subject, string text) : this(receiver)
        {
            Subject = subject;
            Text = text;
        }
    }
}
