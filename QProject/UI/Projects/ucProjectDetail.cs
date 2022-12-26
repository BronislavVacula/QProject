using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using QProject.Base.Attributes;
using QProject.Base.Constants;
using QProject.BL.Entities.Projects;
using QProject.Interfaces;
using QProject.Templates.Controls;

namespace QProject.UI.Projects
{
    [Document(GroupName = DocumentManagerConstants.MODULE_PROJECT_MANAGEMENT, DocumentName = "Detail projektu")]
    public partial class ucProjectDetail : XtraUserControl, IEntityDetail
    {
        #region Properties and fields        
        /// <summary>
        /// The project
        /// </summary>
        private Project? _project;
        #endregion

        #region Constructor and initialization
        /// <summary>
        /// Initializes a new instance of the <see cref="ucProjectDetail"/> class.
        /// </summary>
        public ucProjectDetail()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ucProjectDetail"/> class.
        /// </summary>
        /// <param name="project">The project.</param>
        public ucProjectDetail(Project project)
        {
            InitializeComponent();

            Init(project);
            Init();
        }

        /// <summary>
        /// Initializes the specified project.
        /// </summary>
        /// <param name="project">The project.</param>
        private void Init(Project project)
        {
            _project = project;
        }

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        private void Init()
        {
            ucProjectDetailMainInfo1.Init(_project);
        }
        #endregion

        #region Methods         
        /// <summary>
        /// Closes the content.
        /// </summary>
        /// <returns></returns>
        public bool CloseContent()
        {
            if (navigationDetail.SelectedPage != null && navigationDetail.SelectedPage.Controls.Count > 0)
            {
                if (navigationDetail.SelectedPage.Controls[0] is ucTemplateDetail detail)
                {
                    return detail.CanFinish();
                }
            }

            return true;
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString() => "Detail projektu - " + _project?.Name ?? "";
        #endregion

        #region Event handlers    
        /// <summary>
        /// User selected diffent page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void navigationDetail_SelectedPageChanging(object sender, SelectedPageChangingEventArgs e)
        {
            if(e.OldPage != null 
                && e.OldPage is NavigationPage navigationPage
                && navigationPage.Controls.Count > 0
                && navigationPage.Controls[0] is ucTemplateDetail detail)
            {
                e.Cancel = !detail.CanFinish();
            }
        }

        /// <summary>
        /// Handles the StateChanging event of the navigationDetail control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="StateChangingEventArgs"/> instance containing the event data.</param>
        private void navigationDetail_StateChanging(object sender, StateChangingEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion
    }
}
