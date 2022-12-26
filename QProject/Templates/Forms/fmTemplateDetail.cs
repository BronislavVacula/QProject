using DevExpress.XtraEditors;
using QProject.Base;
using QProject.Base.Enums;
using QProject.Templates.Interfaces;

namespace QProject.Templates.Forms
{
    public partial class fmTemplateDetail : XtraForm, ITemplate
    {
        #region Properties and fields        
        /// <summary>
        /// Gets the editation mode.
        /// </summary>
        /// <value>
        /// The editation mode.
        /// </value>
        public EditationMode EditationMode { get; set; }

        /// <summary>
        /// Gets a value indicating whether this instance has changes.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has changes; otherwise, <c>false</c>.
        /// </value>
        public bool HasChanges { get; set; }

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
        /// Initializes a new instance of the <see cref="fmTemplateDetail"/> class.
        /// </summary>
        public fmTemplateDetail()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="fmTemplateDetail"/> class.
        /// </summary>
        /// <param name="editationMode">The editation mode.</param>
        public fmTemplateDetail(EditationMode editationMode)
        {
            InitializeComponent();

            EditationMode = editationMode;
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
            btnOK.Visible = EditationMode != EditationMode.Editation || EditationMode == EditationMode.New;
            btnFinish.Visible = EditationMode != EditationMode.ReadOnly;
            btnSaveChanges.Visible = EditationMode == EditationMode.Editation;
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
        /// Handles the Click event of the btnFinish control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public virtual void btnFinish_Click(object sender, EventArgs e)
        {
            if (CanFinish())
            {
                if(HasChanges)
                    RollbackChanges();

                DialogResult = DialogResult.Cancel;
            }
        }

        /// <summary>
        /// Handles the Click event of the btnSaveChanges control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public virtual void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if(CanSaveContent())
            {
                SaveContent();

                DialogResult = DialogResult.OK;
            }
        }

        /// <summary>
        /// Handles the Click event of the btnOK control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public virtual void btnOK_Click(object sender, EventArgs e)
        {
            if (EditationMode != EditationMode.ReadOnly && CanSaveContent())
            {
                SaveContent();

                DialogResult = DialogResult.OK;
            }
            else DialogResult = DialogResult.OK;
        }
        #endregion
    }
}