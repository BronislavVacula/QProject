using System.ComponentModel;

namespace QProject.Base.Enums
{
    /// <summary>
    /// The priority
    /// </summary>
    public enum Priority
    {
        [Description("Nízká")]
        Low,
        [Description("Střední")]
        Medium,
        [Description("Vysoká")]
        Hight,
        [Description("Kritická")]
        Critical
    }

    /// <summary>
    /// Action
    /// </summary>
    public enum MenuItemOpenAction
    {
        Control,
        Form,
    }
}
