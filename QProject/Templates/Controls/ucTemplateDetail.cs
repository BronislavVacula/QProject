using DevExpress.XtraEditors;
using QProject.Base;
using QProject.Base.Enums;
using QProject.BL.Entities.Projects;
using QProject.Templates.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QProject.Templates.Controls
{
    public partial class ucTemplateDetail : XtraUserControl, ITemplate
    {
        #region Properties and fields
        /// <summary>
        /// Gets the editation mode.
        /// </summary>
        /// <value>
        /// The editation mode.
        /// </value>
        public EditationMode EditationMode { get; private set; } = EditationMode.Editable;

        /// <summary>
        /// Gets a value indicating whether this instance has changes.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has changes; otherwise, <c>false</c>.
        /// </value>
        protected bool HasChanges { get; private set; }

        /// <summary>
        /// Gets the related entity.
        /// </summary>
        /// <value>
        /// The related entity.
        /// </value>
        public Entity? RelatedEntity { get; set; }
        #endregion

        #region Constructor and initialization
        /// <summary>
        /// Initializes a new instance of the <see cref="ucTemplateDetail"/> class.
        /// </summary>
        public ucTemplateDetail()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes the specified project.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <param name="editationMode">The editation mode.</param>
        public void Init(Project? project, EditationMode editationMode)
        {
            RelatedEntity = project;
            EditationMode = editationMode;

            Init();
        }

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        public virtual void Init()
        {
            InitBinding();
            InitComboBoxes();
            LoadContent();
            UpdateState();
        }

        /// <summary>
        /// Initializes the binding.
        /// </summary>
        public virtual void InitBinding()
        {

        }

        /// <summary>
        /// Initializes the combo boxes.
        /// </summary>
        public virtual void InitComboBoxes()
        {

        }
        #endregion

        #region Methods
        /// <summary>
        /// Reloads this instance.
        /// </summary>
        public virtual void Reload()
        {
            LoadContent();
            UpdateState();
        }

        /// <summary>
        /// Updates the state.
        /// </summary>
        public virtual void UpdateState()
        {
            UpdateUIAccess();
            UpdateContent();
        }

        /// <summary>
        /// Loads the content.
        /// </summary>
        public virtual void LoadContent()
        {

        }

        /// <summary>
        /// Updates the content.
        /// </summary>
        public virtual void UpdateContent()
        {

        }

        /// <summary>
        /// Saves the content.
        /// </summary>
        public virtual void SaveContent()
        {
            HasChanges = false;
        }

        /// <summary>
        /// Updates the UI access.
        /// </summary>
        /// <returns></returns>
        public virtual void UpdateUIAccess()
        {
            btnChange.Visible = EditationMode == EditationMode.Editable;
            btnSaveChanges.Visible = EditationMode == EditationMode.Editation;
            btnFinish.Visible = EditationMode == EditationMode.Editation;
        }

        /// <summary>
        /// Determines whether this instance can finish.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance can finish; otherwise, <c>false</c>.
        /// </returns>
        public virtual bool CanFinish()
        {
            if (HasChanges)
            {
                return XtraMessageBox.Show("Provedené změny nebudou uloženy, pokračovat?", "Uložení změn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
            }

            return true;
        }

        /// <summary>
        /// Rollbacks the changes.
        /// </summary>
        public virtual void RollbackChanges()
        {

        }

        /// <summary>
        /// Determines whether this instance [can save content].
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance [can save content]; otherwise, <c>false</c>.
        /// </returns>
        public virtual bool CanSaveContent()
        {
            return true;
        }
        #endregion

        #region Event handlers
        /// <summary>
        /// Handles the Click event of the btnChange control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public virtual void btnChange_Click(object sender, EventArgs e)
        {
            EditationMode = EditationMode.Editation;

            UpdateState();
        }

        /// <summary>
        /// Handles the Click event of the btnSaveChanges control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public virtual void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (CanSaveContent())
            {
                SaveContent();
            }
        }

        /// <summary>
        /// Handles the Click event of the btnFinish control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public virtual void btnFinish_Click(object sender, EventArgs e)
        {
            if(CanFinish())
            {
                if(HasChanges)
                    RollbackChanges();

                EditationMode = EditationMode.Editable;

                UpdateState();
            }
        }
        #endregion
    }
}
