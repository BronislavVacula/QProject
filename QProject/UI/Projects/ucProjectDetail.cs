using DevExpress.XtraEditors;
using QProject.Base.Enums;
using QProject.BL.Entities.Projects;
using QProject.Templates.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QProject.UI.Projects
{
    public partial class ucProjectDetail : XtraUserControl
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
            ucProjectDetailMainInfo1.Init(_project, EditationMode.Editable);
        }
        #endregion

        #region Methods        
        #endregion

        #region Event handlers
        #endregion
    }
}
