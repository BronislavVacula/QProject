using QProject.Base.Classes.Mailing;
using QProject.Base.DatabaseConnection;
using QProject.Base.Enums;
using QProject.BL.Entities.Administration;
using QProject.BL.Facade.Administration;

namespace QProject.BL
{
    public class NotificationManager
    {
        /// <summary>
        /// Sends the notification.
        /// </summary>
        /// <param name="receiver">The receiver.</param>
        /// <param name="receiverId">The receiver identifier.</param>
        /// <param name="notification">The notification.</param>
        public void SendNotification(NotificationReciver receiver, int? receiverId, Notification notification)
        {
            if (receiverId.HasValue)
            {
                if (receiver == NotificationReciver.User)
                {
                    SendUserNotification(receiverId, notification);
                }
                else if (receiver == NotificationReciver.Role)
                {
                    IEnumerable<int> membersIds = fRoles.Instance.GetRoleMembersIds(receiverId);

                    foreach (int memberId in membersIds)
                    {
                        SendNotification(NotificationReciver.User, memberId, notification);
                    }
                }
            }
        }

        /// <summary>
        /// Sends the user notification.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <param name="notification">The notification.</param>
        /// <returns></returns>
        public void SendUserNotification(int? userId, Notification notification)
        {
            SendUserNotification(userId, notification.Subject, notification.ToString());
        }

        /// <summary>
        /// Sends the user notification.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <param name="subject">The subject.</param>
        /// <param name="text">The text.</param>
        public void SendUserNotification(int? userId, string subject, string text)
        {
            User? receiverUser = DBConn.Instance.Find<User>(userId);

            if (receiverUser != null)
            {
                if (receiverUser.NotificationType.HasFlag(NotificationType.Email) && !string.IsNullOrEmpty(receiverUser.Email))
                {
                    Mailer.Instance.SendMail(receiverUser.Email, subject, text);
                }
            }
        }
    }
}
