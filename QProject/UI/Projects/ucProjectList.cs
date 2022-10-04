using DevExpress.XtraEditors;
using QProject.BL.Entities.Projects;
using QProject.Templates.Controls;
using QProject.UI.Projects.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QProject.UI.Projects
{
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
        #endregion
    }
}
