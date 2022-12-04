namespace QProject.Base.Enums.Projects
{
    /// <summary>
    /// State of the project
    /// </summary>
    public enum ProjectState
    {
        New = 0,
        InProgress = 1,
        CloseToDeadline = 2,
        AfterDeadline = 3,
        Finished = 4,
        Canceled = 5,
    }
}
