namespace QProject.Base.Enums
{
    /// <summary>
    /// Editation mode
    /// </summary>
    public enum EditationMode
    {
        New,
        ReadOnly,
        Editable,
        Editation,
    }

    /// <summary>
    /// Receiver of the notification
    /// </summary>
    public enum NotificationReciver
    {
        User,
        Role,
    }

    /// <summary>
    /// Type of the notification
    /// </summary>
    [Flags]
    public enum NotificationType
    {
        None = 0,
        Popup = 2,
        Email = 4,
    }

    /// <summary>
    /// Entity action (for UC notifications)
    /// </summary>
    public enum EntityAction
    {
        Create,
        Update,
        Delete
    }
}
