using QProject.Base;
using QProject.Base.Enums;
using QProject.BL.Entities.Projects;
using QProject.Extensions;
using QProject.Templates.Controls;
using System;
using System.Windows.Forms;

namespace QProject.UI.Projects
{
    public partial class ucProjectDetailMainInfo : ucTemplateDetail
    {
        #region Properties and fields
        /// <summary>
        /// THe project
        /// </summary>
        private Project? _project;
        #endregion

        #region Constructor and initialization
        /// <summary>
        /// Initializes a new instance of the <see cref="ucProjectDetailMainInfo"/> class.
        /// </summary>
        public ucProjectDetailMainInfo()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ucProjectDetailMainInfo"/> class.
        /// </summary>
        /// <param name="project"></param>
        public ucProjectDetailMainInfo(Project project)
        {
            InitializeComponent();

            Init(project);
            Init();
        }

        /// <summary>
        /// Initializes the project
        /// </summary>
        /// <param name="project"></param>
        private void Init(Project project)
        {
            _project = project;
        }

        /// <summary>
        /// Initializes the combo boxes.
        /// </summary>
        public override void InitComboBoxes()
        {
            base.InitComboBoxes();

            cbPriority.LoadWithEnum<Priority>();
        }

        /// <summary>
        /// Initializes the binding.
        /// </summary>
        public override void InitBinding()
        {
            base.InitBinding();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Updates the UI access.
        /// </summary>
        public override void UpdateUIAccess()
        {
            base.UpdateUIAccess();

            //States
            bool isReadOnly = EditationMode == EditationMode.ReadOnly || EditationMode == EditationMode.Editable;

            //Components
            txtProjectNumber.ReadOnly = isReadOnly;
            txtProjectName.ReadOnly = isReadOnly;
            cbCategory.ReadOnly = isReadOnly;
            cbPriority.ReadOnly = isReadOnly;

            cbCustomer.ReadOnly = isReadOnly;
            txtMainContact.ReadOnly = isReadOnly;

            sePlanEarnings.ReadOnly = isReadOnly;
            seRealEarnings.ReadOnly = isReadOnly;
            sePlanExpenses.ReadOnly = isReadOnly;
            seRealExpenses.ReadOnly = isReadOnly;
            seMoneyState.ReadOnly = isReadOnly;

            dePlanStart.ReadOnly = isReadOnly;
            deRealStart.ReadOnly = isReadOnly;
            deDeadline.ReadOnly = isReadOnly;
            deRealFinish.ReadOnly = isReadOnly;

            reDescription.ReadOnly = isReadOnly;
        }

        /// <summary>
        /// Editation can be finished
        /// </summary>
        /// <returns></returns>
        public override bool CanFinish()
        {
            if (RelatedEntity?.IsModified ?? false)
            {
                return base.CanFinish();
            }

            return true;
        }

        /// <summary>
        /// Saves the content
        /// </summary>
        public override void SaveContent()
        {
            if (RelatedEntity != null)
            {
                EntityManager.SaveEntity(RelatedEntity);
            }

            base.SaveContent();
        }

        /// <summary>
        /// Rollbacks the changes
        /// </summary>
        public override void RollbackChanges()
        {
            if(_project != null)
            {
                EntityManager.RollbackEntity(_project);
            }

            base.RollbackChanges();
        }
        #endregion

        #region Event handlers
        #endregion
    }
}
