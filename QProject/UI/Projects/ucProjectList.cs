using QProject.Base;
using QProject.Base.Attributes;
using QProject.Base.Constants;
using QProject.BL.Entities.Projects;
using QProject.Templates.Controls;
using QProject.UI.Projects.Forms;

namespace QProject.UI.Projects
{
    [Document(GroupName = DocumentManagerConstants.PROJECT_MANAGEMENT, DocumentName = "Přehled projektů")]
    public partial class ucProjectList : ucTemplateList
    {
        #region Properties and fields        
        /// <summary>
        /// The projects
        /// </summary>
        private List<Project> projects = new();
        #endregion

        #region Constructor and initialization
        /// <summary>
        /// Initializes a new instance of the <see cref="ucProjectList"/> class.
        /// </summary>
        public ucProjectList()
        {
            InitializeComponent();
            Init();
        }
        #endregion

        #region Methods        
        /// <summary>
        /// Initializes this instance.
        /// </summary>
        private void Init()
        {
            LoadContent();
        }

        /// <summary>
        /// Loads the content.
        /// </summary>
        private void LoadContent()
        {

        }
        #endregion

        #region Event handlers
        /// <summary>
        /// Handles the Click event of the btnNewItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnNewItem_Click(object sender, EventArgs e)
        {
            using fmNewProject newProjectDialog = new();

            if (newProjectDialog.ShowDialog() == DialogResult.OK)
            {
                projects.Add(newProjectDialog.Result);

                gvProjects.RefreshData();
            }
        }

        /// <summary>
        /// Handles the Click event of the btnPreview control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (gvProjects.GetFocusedRow() is Project project)
            {

            }
        }

        /// <summary>
        /// Handles the Click event of the btnEdit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gvProjects.GetFocusedRow() is Project project)
            {

            }
        }

        /// <summary>
        /// Handles the Click event of the btnRemove control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (gvProjects.GetFocusedRow() is Project project)
            {
                EntityManager.DeleteEntity(project);

                if (projects.Contains(project))
                    projects.Remove(project);

                gvProjects.RefreshData();
            }
        }
        #endregion
    }
}
