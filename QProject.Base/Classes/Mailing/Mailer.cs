using QProject.Base.DatabaseConnection;

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

        #region Methods        
        /// <summary>
        /// Sends the mail.
        /// </summary>
        public void SendMail(string receiver, string subject, string text)
        {

        }
        #endregion
    }
}
