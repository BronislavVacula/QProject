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
                    User? receiverUser = DBConn.Instance.Find<User>(receiverId);

                    if (receiverUser != null)
                    {
                        if (receiverUser.NotificationType.HasFlag(NotificationType.Email)
                            && !string.IsNullOrEmpty(receiverUser.Email))
                        {
                            Mailer.Instance.SendMail(receiverUser.Email, notification.Subject, notification.ToString());
                        }
                    }
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
    }
}
