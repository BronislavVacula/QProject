using System.ComponentModel;

namespace QProject.Base.Enums.Projects
{
    /// <summary>
    /// State of the project
    /// </summary>
    public enum ProjectState
    {
        [Description("Nový")]
        New = 0,
        [Description("Probíhající")]
        InProgress = 1,
        [Description("Blížící se termín")]
        CloseToDeadline = 2,
        [Description("Po termínu")]
        AfterDeadline = 3,
        [Description("Dokončený")]
        Finished = 4,
        [Description("Zrušený")]
        Canceled = 5,
    }
}
