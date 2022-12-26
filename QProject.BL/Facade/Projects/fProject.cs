using QProject.Base.DatabaseConnection;
using QProject.BL.Entities.Projects;
using SqlKata.Execution;

namespace QProject.BL.Facade.Projects
{
    public class fProject
    {
        #region Singleton        
        /// <summary>
        /// The instance
        /// </summary>
        private static fProject? instance;

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>
        /// The instance.
        /// </value>
        public static fProject Instance => instance ??= new fProject();

        /// <summary>
        /// Prevents a default instance of the <see cref="fProject"/> class from being created.
        /// </summary>
        private fProject() { }
        #endregion

        #region Methods        
        /// <summary>
        /// Saves the project.
        /// </summary>
        /// <param name="project">The project.</param>
        public void SaveProject(Project project)
        {
            if (!project.IsSaved)
            {
                project.NumberInt = GetNextProjectNumber();
                project.Number = "PR" + project.NumberInt.ToString("D4") + "/" + DateTime.Now.Year.ToString();
            }

            project.Save();
        }

        /// <summary>
        /// Gets the next project number.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <returns></returns>
        public int GetNextProjectNumber()
        {
            int lastNumber = DBConn.Instance.CreateQuery<Project>()
                ?.Select(nameof(Project.NumberInt))
                .OrderByDesc(nameof(Project.NumberInt))
                ?.FirstOrDefault<int>() ?? 0;

            return lastNumber + 1;
        }
        #endregion
    }
}
