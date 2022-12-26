using QProject.Base.Constants.Administration;
using QProject.Base.Enums;
using QProject.BL.Entities.Administration;
using QProject.BL.Entities.Projects;
using QProject.BL.Facade.Projects;
using QProject.Classes.Validation;
using QProject.Classes.Validation.Rules;
using QProject.Extensions;
using QProject.Templates.Forms;

namespace QProject.UI.Projects.Forms
{
    public partial class fmNewProject : fmTemplateDetail
    {
        #region Properties and fields
        /// <summary>
        /// Gets or sets the result.
        /// </summary>
        /// <value>
        /// The result.
        /// </value>
        public Project Result { get; set; } = new Project();
        #endregion

        #region Constructor and initialization
        /// <summary>
        /// Initializes a new instance of the <see cref="fmNewProject"/> class.
        /// </summary>
        public fmNewProject()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        public override void Init()
        {
            InitForm();

            base.Init();
        }

        /// <summary>
        /// Initializes the form.
        /// </summary>
        private void InitForm()
        {
            EditationMode = EditationMode.New;
            HasChanges = true;
        }

        /// <summary>
        /// Initializes the combo boxes.
        /// </summary>
        public override void InitComboBoxes()
        {
            ceCategory.LoadWithEnumeration(EnumerationCodes.PROJECT_CATEGORY, 0);
            cbPriority.LoadWithEnum<Priority>(1);
            cbCustomer.LoadWithEntities<Company>(nameof(Company.IsCustomer), true, "=", 0);
        }
        #endregion

        #region Methods        
        /// <summary>
        /// Determines whether this instance [can save content].
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance [can save content]; otherwise, <c>false</c>.
        /// </returns>
        public override bool CanSaveContent()
        {
            Validator.ClearValidatorErrors();

            bool result = true;

            result &= Validator.ValidateControl(teProjectName, new NotEmptyRule());
            result &= Validator.ValidateControl(ceCategory, new NotEmptyRule());
            result &= Validator.ValidateControl(cbPriority, new NotEmptyRule());

            return result;
        }

        /// <summary>
        /// Saves this instance
        /// </summary>
        public override void SaveContent()
        {
            base.SaveContent();

            Result.Name = teProjectName.Text;
            Result.MainContact = teMainContact.Text;
            Result.PlanEarnings = sePlanEarnings.Value;
            Result.PlanExpenses = sePlanExpenses.Value;
            Result.PlanStartAt = dePlanStart.EditValue as DateTime?;
            Result.Deadline = deDeadline.EditValue as DateTime?;
            Result.Description = reDescription.Text;
            Result.Priority = cbPriority.GetSelectedItem<Priority>();
            Result.Category = ceCategory.GetSelectedItem<EnumerationItem>();
            Result.Company = cbCustomer.GetSelectedItem<Company>();

            //Save entity to database
            fProject.Instance.SaveProject(Result);

            //Close
            DialogResult = DialogResult.OK;
        }
        #endregion

        #region Event handlers
        #endregion
    }
}