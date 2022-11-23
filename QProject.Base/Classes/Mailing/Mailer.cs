using QProject.Base.Interfaces;
using System.Net;
using System.Net.Mail;

namespace QProject.Base.Classes.Mailing
{
    public class Mailer
    {
        #region Singleton        
        /// <summary>
        /// The instance
        /// </summary>
        private static Mailer? instance;

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>
        /// The instance.
        /// </value>
        public static Mailer Instance => instance ??= new Mailer();

        /// <summary>
        /// Prevents a default instance of the <see cref="Mailer"/> class from being created.
        /// </summary>
        private Mailer() { }
        #endregion

        #region Properties and fields        
        /// <summary>
        /// Gets or sets the SMTP settings.
        /// </summary>
        /// <value>
        /// The SMTP settings.
        /// </value>
        public ISmtpSettings SmtpSettings { get; private set; }
        #endregion

        #region Constructor and initialization        
        /// <summary>
        /// Initializes the settings.
        /// </summary>
        /// <param name="smtpSettings">The SMTP settings.</param>
        public void InitSettings(ISmtpSettings smtpSettings)
        {
            SmtpSettings = smtpSettings;
        }
        #endregion

        #region Methods    
        /// <summary>
        /// Sends the mail.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns></returns>
        public bool SendMail(MailMessage message)
        {
            using (SmtpClient smtpClient = new()
            {
                Host = SmtpSettings?.Server ?? "",
                Port = Convert.ToInt32(SmtpSettings?.Port ?? 21),
                Credentials = new NetworkCredential(SmtpSettings?.Username ?? "", SmtpSettings?.Password ?? ""),
                EnableSsl = true,
            })
            {
                smtpClient.Send(new System.Net.Mail.MailMessage(SmtpSettings?.SenderEmailAddress ?? "", message.Receiver, message.Subject, message.Text));
            }

            return false;
        }

        /// <summary>
        /// Sends the mail.
        /// </summary>
        /// <param name="receiver">The receiver.</param>
        /// <param name="subject">The subject.</param>
        /// <param name="text">The text.</param>
        /// <returns></returns>
        public bool SendMail(string receiver, string subject, string text)
        {
            return SendMail(new MailMessage(receiver, subject, text));
        }
        #endregion
    }
}
