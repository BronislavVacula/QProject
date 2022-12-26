using QProject.Base.Attributes;
using QProject.Base.Constants;
using QProject.Base.DatabaseConnection;
using QProject.BL.Entities.Projects;

namespace QProject.UI.Projects
{
    [Document(DocumentName = "Komplexní přehled", GroupName = DocumentManagerConstants.MODULE_PROJECT_MANAGEMENT)]
    public partial class ucProjectsStatistics : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ucProjectsStatistics"/> class.
        /// </summary>
        public ucProjectsStatistics()
        {
            InitializeComponent();

            pivotGridControl1.DataSource = DBConn.Instance.GetAll<Project>(true);
        }
    }
}
