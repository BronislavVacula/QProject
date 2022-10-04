using DevExpress.XtraEditors;
using QProject.Base;
using QProject.BL.Entities.Projects;
using QProject.Templates.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QProject.UI.Projects.Forms
{
    public partial class fmNewProject : fmTemplateDetail
    {
        /// <summary>
        /// Gets or sets the result.
        /// </summary>
        public Project Result { get; set; } = EntityManager.ProduceEntity<Project>();

        /// <summary>
        /// Initializes a new instance of the <see cref="fmNewProject"/> class.
        /// </summary>
        public fmNewProject()
        {
            InitializeComponent();

            EditationMode = Base.Enums.EditationMode.New;

            Init();
        }
    }
}