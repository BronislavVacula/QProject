namespace QProject.Base.Classes.Mailing
{
    public class MailMessage
    {
        #region Properties and fields        
        /// <summary>
        /// Gets or sets the receiver (email adress).
        /// </summary>
        /// <value>
        /// The receiver (email adress).
        /// </value>
        public string Receiver { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the subject.
        /// </summary>
        /// <value>
        /// The subject.
        /// </value>
        public virtual string? Subject { get; set; }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>
        /// The text.
        /// </value>
        public virtual string? Text { get; set; }
        #endregion

        #region Constructor and initialization
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
        #endregion
    }
}
