using DevExpress.XtraEditors;
using QProject.BL.Entities.Settings;
using QProject.Classes.Validation;
using QProject.Classes.Validation.Rules;

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

            Init(settingsProfile);
            Init();
        }

        /// <summary>
        /// Initializes the specified settings profile.
        /// </summary>
        /// <param name="settingsProfile">The settings profile.</param>
        private void Init(SettingsProfile settingsProfile)
        {
            SettingsProfile = settingsProfile;
        }

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        private void Init()
        {
            LoadContent();
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
        /// Loads the content.
        /// </summary>
        private void LoadContent()
        {
            if (SettingsProfile != null)
            {
                teProfileName.Text = SettingsProfile.Name;

                teDatabaseServer.Text = SettingsProfile.DatabaseServerSettings.Server;
                seDatabasePort.EditValue = SettingsProfile.DatabaseServerSettings.Port;
                teDatabaseUsername.Text = SettingsProfile.DatabaseServerSettings.Username;
                teDatabaseName.Text = SettingsProfile.DatabaseServerSettings.DatabaseName;
                teDatabasePassword.Text = SettingsProfile.DatabaseServerSettings.Password;

                teSMTPServer.Text = SettingsProfile.MailServerSettings.Server;
                seSMTPPort.EditValue = SettingsProfile.MailServerSettings.Port;
                teSMTPUsername.Text = SettingsProfile.MailServerSettings.Username;
                teSMTPPassword.Text = SettingsProfile.MailServerSettings.Password;
                teSMTPSenderEmail.Text = SettingsProfile.MailServerSettings.SenderEmailAddress;
            }
        }

        /// <summary>
        /// Saves the content.
        /// </summary>
        private void SaveContent()
        {
            SettingsProfile ??= new SettingsProfile();
            SettingsProfile.Name = teProfileName.Text;

            SettingsProfile.DatabaseServerSettings.Server = teDatabaseServer.Text;
            SettingsProfile.DatabaseServerSettings.Port = Convert.ToUInt32(seDatabasePort.EditValue);
            SettingsProfile.DatabaseServerSettings.Username = teDatabaseUsername.Text;
            SettingsProfile.DatabaseServerSettings.DatabaseName = teDatabaseName.Text;
            SettingsProfile.DatabaseServerSettings.Password = teDatabasePassword.Text;

            SettingsProfile.MailServerSettings.Server = teSMTPServer.Text;
            SettingsProfile.MailServerSettings.Port = Convert.ToUInt32(seSMTPPort.EditValue);
            SettingsProfile.MailServerSettings.Username = teSMTPUsername.Text;
            SettingsProfile.MailServerSettings.Password = teSMTPPassword.Text;
            SettingsProfile.MailServerSettings.SenderEmailAddress = teSMTPSenderEmail.Text;
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
            if (ValidateContent())
            {
                SaveContent();

                DialogResult = DialogResult.OK;
            }
        }
        #endregion
    }
}