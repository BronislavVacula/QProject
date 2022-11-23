using DevExpress.XtraEditors;
using QProject.BL.Entities.Settings;
using QProject.Classes.Validation;
using QProject.Classes.Validation.Rules;
using System;
using System.Windows.Forms;

namespace QProject.UI
{
    public partial class fmProfileDetail : XtraForm
    {
        #region Properties and fields        
        /// <summary>
        /// Gets the settings profile.
        /// </summary>
        /// <value>
        /// The settings profile.
        /// </value>
        public SettingsProfile? SettingsProfile { get; private set; }
        #endregion

        #region Constructor and initialization
        /// <summary>
        /// Initializes a new instance of the <see cref="fmProfileDetail"/> class.
        /// </summary>
        public fmProfileDetail()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="fmProfileDetail"/> class.
        /// </summary>
        /// <param name="settingsProfile">The settings profile.</param>
        public fmProfileDetail(SettingsProfile settingsProfile)
        {
            InitializeComponent();

            SettingsProfile = settingsProfile;
        }
        #endregion

        #region Methods        
        /// <summary>
        /// Validates the content.
        /// </summary>
        /// <returns></returns>
        private bool ValidateContent()
        {
            Validator.ClearValidatorErrors();

            bool result = true;
            
            //Database settings
            result &= Validator.ValidateControl(teDatabaseServer, new NotEmptyRule());
            result &= Validator.ValidateControl(teDatabaseName, new NotEmptyRule());
            result &= Validator.ValidateControl(teDatabaseUsername, new NotEmptyRule());
            result &= Validator.ValidateControl(teDatabasePassword, new NotEmptyRule());

            //SMTPM server settings
            result &= Validator.ValidateControl(teSMTPServer, new NotEmptyRule());
            result &= Validator.ValidateControl(teSMTPUsername, new NotEmptyRule());
            result &= Validator.ValidateControl(teSMTPPassword, new NotEmptyRule());
            result &= Validator.ValidateControl(teSMTPSenderEmail, new NotEmptyRule());

            return result;
        }

        /// <summary>
        /// Saves the content.
        /// </summary>
        private void SaveContent()
        {
            if (SettingsProfile == null)
                SettingsProfile = new SettingsProfile();

            SettingsProfile.Name = teProfileName.Text;
        }
        #endregion

        #region Event handlers
        /// <summary>
        /// Handles the Click event of the btnConfirm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(ValidateContent())
            {
                SaveContent();

                DialogResult = DialogResult.OK;
            }
        }
        #endregion
    }
}