using DevExpress.XtraEditors;
using QProject.Base;
using QProject.Base.Constants.Administration;
using QProject.Base.Enums;
using QProject.Base.Enums.Projects;
using QProject.BL.Entities.Administration;
using QProject.BL.Entities.Projects;
using QProject.Classes.ChangeTrack;
using QProject.Extensions;
using QProject.Templates.Controls;

namespace QProject.UI.Projects
{
    public partial class ucProjectDetailMainInfo : ucTemplateDetail
    {
        #region Properties and fields
        /// <summary>
        /// THe project
        /// </summary>
        private Project _project = new();

        /// <summary>
        /// The change tracker
        /// </summary>
        private readonly ChangeTracker<Project> changeTracker = new();
        #endregion

        #region Constructor and initialization
        /// <summary>
        /// Initializes a new instance of the <see cref="ucProjectDetailMainInfo"/> class.
        /// </summary>
        public ucProjectDetailMainInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes the specified project.
        /// </summary>
        /// <param name="project">The project.</param>
        public void Init(Project project)
        {
            _project = project;

            Init(project, EditationMode.Editable);
        }

        /// <summary>
        /// Initializes the combo boxes.
        /// </summary>
        public override void InitComboBoxes()
        {
            base.InitComboBoxes();

            cbCategory.LoadWithEnumeration(EnumerationCodes.PROJECT_CATEGORY, 0);
            cbPriority.LoadWithEnum<Priority>(1);
            cbCustomer.LoadWithEntities<Company>(nameof(Company.IsCustomer), true, "=", 0);
        }

        /// <summary>
        /// Initializes the binding.
        /// </summary>
        public override void InitBinding()
        {
            base.InitBinding();

            //Main data
            changeTracker.Bind(txtProjectNumber, nameof(TextEdit.Text), _project, nameof(Project.Number));
            changeTracker.Bind(txtProjectName, nameof(TextEdit.Text), _project, nameof(Project.Name));
            changeTracker.Bind(txtMainContact, nameof(TextEdit.Text), _project, nameof(Project.MainContact));
            changeTracker.Bind(cbCategory, nameof(ComboBoxEdit.EditValue), _project, nameof(Project.Category), true, nameof(Project.CategoryId));
            changeTracker.Bind(cbCustomer, nameof(ComboBoxEdit.EditValue), _project, nameof(Project.Company), true, nameof(Project.CustomerId));
            changeTracker.Bind(cbPriority, nameof(ComboBoxEdit.EditValue), _project, nameof(Project.Priority));

            //Plan & real values
            changeTracker.Bind(sePlanEarnings, nameof(SpinEdit.Value), _project, nameof(Project.PlanEarnings));
            changeTracker.Bind(sePlanExpenses, nameof(SpinEdit.Value), _project, nameof(Project.CurrentEarnings));
            changeTracker.Bind(seRealEarnings, nameof(SpinEdit.Value), _project, nameof(Project.PlanExpenses));
            changeTracker.Bind(seRealExpenses, nameof(SpinEdit.Value), _project, nameof(Project.CurrentExpenses));

            //Terms
            changeTracker.Bind(dePlanStart, nameof(DateEdit.EditValue), _project, nameof(Project.PlanStartAt));
            changeTracker.Bind(deDeadline, nameof(DateEdit.EditValue), _project, nameof(Project.Deadline));
            changeTracker.Bind(deRealStart, nameof(DateEdit.EditValue), _project, nameof(Project.RealStartAt));
            changeTracker.Bind(deRealFinish, nameof(DateEdit.EditValue), _project, nameof(Project.FinishedAt));

            //Description
            changeTracker.Bind(reDescription, nameof(Components.QRichEdit.Text), _project, nameof(Project.Description));
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
            bool isNotStarted = _project.State < ProjectState.InProgress;

            //Components
            txtProjectNumber.ReadOnly = isReadOnly;
            txtProjectName.ReadOnly = isReadOnly;
            cbCategory.ReadOnly = isReadOnly;
            cbPriority.ReadOnly = isReadOnly;

            cbCustomer.ReadOnly = isReadOnly;
            txtMainContact.ReadOnly = isReadOnly;

            sePlanEarnings.ReadOnly = isReadOnly && isNotStarted;
            sePlanExpenses.ReadOnly = isReadOnly && isNotStarted;

            dePlanStart.ReadOnly = isReadOnly && isNotStarted;
            deDeadline.ReadOnly = isReadOnly;

            reDescription.ReadOnly = isReadOnly;
        }

        /// <summary>
        /// Editation can be finished
        /// </summary>
        /// <returns></returns>
        public override bool CanFinish()
        {
            if (_project != null)
            {
                HasChanges = changeTracker.HasEntityChanges();

                return base.CanFinish();
            }

            return true;
        }

        /// <summary>
        /// Determines whether this instance [can save content].
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance [can save content]; otherwise, <c>false</c>.
        /// </returns>
        public override bool CanSaveContent()
        {
            bool result = base.CanSaveContent();
            return result;
        }

        /// <summary>
        /// Saves the content
        /// </summary>
        public override void SaveContent()
        {
            if (changeTracker.HasEntityChanges())
            {
                var changedColumnValues = changeTracker.GetChangedColumnValues()?.ToList();

                EntityManager.SaveEntity(_project, changedColumnValues);

                changeTracker.SaveChanges();
            }

            base.SaveContent();
        }
        #endregion

        #region Event handlers        
        /// <summary>
        /// Handles the ValueChanged event of the seFianncial control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void seFianncial_ValueChanged(object sender, EventArgs e)
        {
            seMoneyState.EditValue = (_project.CurrentEarnings ?? 0m) - (_project.CurrentExpenses ?? 0m);
        }
        #endregion
    }
}
