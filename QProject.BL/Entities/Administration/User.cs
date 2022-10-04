using QProject.Base;
using QProject.Base.Enums;

namespace QProject.BL.Entities.Administration
{
    public class User : Entity
    {
        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        /// <value>
        /// The username.
        /// </value>
        public string? Username 
        {
            get => GetPropertyValue<string?>();
            set => SetPropertyValue(value);
        }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        public string? Password
        {
            get => GetPropertyValue<string?>();
            set => SetPropertyValue(value);
        }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        public string? Email
        {
            get => GetPropertyValue<string?>();
            set => SetPropertyValue(value);
        }

        /// <summary>
        /// Gets or sets the type of the notification.
        /// </summary>
        /// <value>
        /// The type of the notification.
        /// </value>
        public NotificationType NotificationType
        {
            get => GetPropertyValue<NotificationType>();
            set => SetPropertyValue(value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        public User()
        {
            CreateProperty<string?>(nameof(Username), string.Empty);
            CreateProperty<string?>(nameof(Password), string.Empty);
            CreateProperty<string?>(nameof(Email), string.Empty);
            CreateProperty<NotificationType>(nameof(NotificationType), NotificationType.Email);
        }
    }
}
