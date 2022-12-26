using QProject.Base;
using QProject.Base.Enums;
using QProject.Shared.Attributes;

namespace QProject.BL.Entities.Administration
{
    [DatabaseTable(TableName = "users")]
    public class User : Entity
    {
        #region Properties and fields
        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        /// <value>
        /// The username.
        /// </value>
        public string? Username { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        public string? Password { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        public string? Email { get; set; }

        /// <summary>
        /// Gets or sets the type of the notification.
        /// </summary>
        /// <value>
        /// The type of the notification.
        /// </value>
        public NotificationType NotificationType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="User"/> is activated.
        /// </summary>
        /// <value>
        ///   <c>true</c> if activated; otherwise, <c>false</c>.
        /// </value>
        public bool Activated { get; set; }
        #endregion
    }
}
