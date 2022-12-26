using QProject.Base;
using QProject.Base.Attributes;
using QProject.Base.Constants;
using QProject.Base.DatabaseConnection;
using QProject.Base.Enums;
using QProject.Base.Enums.Projects;
using QProject.BL.Entities.Projects;
using QProject.Classes;
using QProject.Templates.Controls;
using QProject.UI.Projects.Forms;
using SqlKata.Execution;

namespace QProject.UI.Projects
{
    [Document(GroupName = DocumentManagerConstants.MODULE_PROJECT_MANAGEMENT, DocumentName = "Přehled projektů")]
    public partial class ucProjectList : ucTemplateList
    {
        #region Properties and fields        
        /// <summary>
        /// The projects
        /// </summary>
        private List<Project>? projects = new();

        /// <summary>
        /// The state filter
        /// </summary>
        private ProjectState[]? stateFilter;
        #endregion

        #region Constructor and initialization
        /// <summary>
        /// Initializes a new instance of the <see cref="ucProjectList"/> class.
        /// </summary>
        public ucProjectList()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ucProjectList"/> class.
        /// </summary>
        /// <param name="stateFilter">The state filter.</param>
        public ucProjectList(ProjectState[] stateFilter)
        {
            InitializeComponent();

            Init(stateFilter);
            Init();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stateFilter"></param>
        private void Init(ProjectState[] stateFilter)
        {
            this.stateFilter = stateFilter;
        }

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        private void Init()
        {
            InitComboBoxes();
            LoadContent();
        }

        /// <summary>
        /// Initializes the combo boxes.
        /// </summary>
        private void InitComboBoxes()
        {
            InitComboBoxState();
        }

        /// <summary>
        /// Initializes the state ComboBox.
        /// </summary>
        private void InitComboBoxState()
        {
            riPriority.Items.AddEnum<Priority>();
            riState.Items.AddEnum<ProjectState>();
        }
        #endregion

        #region Methods  
        /// <summary>
        /// Loads the content.
        /// </summary>
        private void LoadContent()
        {
            gridProjects.DataSource = projects = DBConn.Instance.CreateQuery<Project>(queryOnView: true)
                ?.WhereIn(nameof(Project.State), stateFilter)
                .Get<Project>()
                .ToList();
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
                projects ??= new List<Project>();
                projects.Add(newProjectDialog.Result);

                gvProjects.RefreshData();
            }
        }

        /// <summary>
        /// Handles the Click event of the riProjectNumber control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void riProjectNumber_Click(object sender, EventArgs e)
        {
            if (gvProjects.GetFocusedRow() is Project project)
            {
                DocumentManagerEx.Instance.OpenDocument<ucProjectDetail>(project);
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

                if (projects != null && projects.Contains(project))
                    projects.Remove(project);

                gvProjects.RefreshData();
            }
        }

        /// <summary>
        /// Handles the MouseUp event of the gvProjects control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void gvProjects_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && gvProjects.GetFocusedRow() is Project project)
            {
                menuProjects.Show(gridProjects, e.Location); 
            }
        }
        #endregion
    }
}
