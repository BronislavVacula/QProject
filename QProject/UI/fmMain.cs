using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using QProject.Base.DatabaseConnection;
using QProject.Base.Enums.Projects;
using QProject.BL.Facade.Administration;
using QProject.Classes;
using QProject.Classes.DocumentManager;
using QProject.Interfaces;
using QProject.Templates.Controls;
using QProject.UI;

namespace QProject
{
    public partial class fmMain : RibbonForm
    {
        #region Properties and fields       
        #endregion

        #region Constructor and initialization
        /// <summary>
        /// Initializes a new instance of the <see cref="fmMain"/> class.
        /// </summary>
        public fmMain()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        private void Init()
        {
            InitProfileSelection();
            InitDatabaseConnection();
            InitDocumentManager();
            InitMenuItems();
        }

        /// <summary>
        /// Initializes the profile selection.
        /// </summary>
        private void InitProfileSelection()
        {
            using var profileSelectionDialog = new fmProfileSelection();

            profileSelectionDialog.ShowDialog();
        }

        /// <summary>
        /// Initializes the database connection.
        /// </summary>
        private void InitDatabaseConnection()
        {
            if (fProfile.Instance.CurrentProfile != null)
            {
                DBConn.Instance.Init(fProfile.Instance.CurrentProfile?.DatabaseServerSettings.ToString() ?? "");
            }
        }

        /// <summary>
        /// Initializes the document manager.
        /// </summary>
        private void InitDocumentManager()
        {
            DocumentManagerEx.Instance.Init(navigator, tabbedView1);
        }

        /// <summary>
        /// Initializes the menu items.
        /// </summary>
        /// <returns></returns>
        private void InitMenuItems()
        {
            InitAdministrationMenuItems();
            InitProjectsMenuItems();
            InitAgendaMenuItems();
            InitStockMenuItems();
            InitFinancialMenuItems();
            InitSettingsMenuItems();
            InitHelpMenuItems();
        }

        /// <summary>
        /// Initializes the administration menu items.
        /// </summary>
        private void InitAdministrationMenuItems()
        {

        }

        /// <summary>
        /// Initializes the projects menu items.
        /// </summary>
        private void InitProjectsMenuItems()
        {
            biNewProject.Tag = biCreateNewProject.Tag = new MenuItemForm<UI.Projects.Forms.fmNewProject>(true);
            biOpenWorkingProjects.Tag = new MenuItemUC<UI.Projects.ucProjectList>(new ProjectState[] { ProjectState.New, ProjectState.InProgress, ProjectState.Finished, ProjectState.AfterDeadline });
            biOpenFinishedProjects.Tag = new MenuItemUC<UI.Projects.ucProjectList>(new ProjectState[] { ProjectState.Finished });
            biOpenCanceledProjects.Tag = new MenuItemUC<UI.Projects.ucProjectList>(new ProjectState[] { ProjectState.Canceled });
            biProjectComplexOverview.Tag = new MenuItemUC<UI.Projects.ucProjectsStatistics>();
        }

        /// <summary>
        /// Initializes the agenda menu items.
        /// </summary>
        private void InitAgendaMenuItems()
        {

        }

        /// <summary>
        /// Initializes the stock menu items.
        /// </summary>
        private void InitStockMenuItems()
        {

        }

        /// <summary>
        /// Initializes the financial menu items.
        /// </summary>
        private void InitFinancialMenuItems()
        {

        }

        /// <summary>
        /// Initializes the settings menu items.
        /// </summary>
        private void InitSettingsMenuItems()
        {

        }

        /// <summary>
        /// Initializes the help menu items.
        /// </summary>
        private void InitHelpMenuItems()
        {

        }
        #endregion

        #region Methods
        #endregion

        #region Event handlers        
        /// <summary>
        /// Handles the Click event of the RibbonItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void RibbonItem_Click(object sender, ItemClickEventArgs e)
        {
            if (e.Item is BarButtonItem barButtonItem && barButtonItem.Tag is MenuItem menuItem)
            {
                menuItem.Open();
            }
        }

        /// <summary>
        /// Handles the DocumentClosing event of the tabbedView1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraBars.Docking2010.Views.DocumentCancelEventArgs"/> instance containing the event data.</param>
        private void tabbedView1_DocumentClosing(object sender, DevExpress.XtraBars.Docking2010.Views.DocumentCancelEventArgs e)
        {
            bool isNotDetail = e.Document.Control is not IEntityDetail;
            bool modificationFinished = e.Document.Control is IEntityDetail detail && detail.CloseContent();

            if (e.Document.Control is UserControl closingUC && (isNotDetail || modificationFinished))
            {
                DocumentManagerEx.Instance.CloseDocument(closingUC, false);
            }
            else e.Cancel = true;
        }

        /// <summary>
        /// The form is closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            fProfile.Instance.SaveProfiles();
        }
        #endregion
    }
}