using DevExpress.XtraEditors;
using QProject.BL.Entities.Settings;
using QProject.BL.Facade.Administration;

namespace QProject.UI
{
    public partial class fmProfileSelection : XtraForm
    {
        #region Properties and fields
        #endregion

        #region Constructor and initialization
        /// <summary>
        /// Initializes a new instance of the <see cref="fmProfileSelection"/> class.
        /// </summary>
        public fmProfileSelection()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        private void Init()
        {
            LoadProfiles();
        }
        #endregion

        #region Methods        
        /// <summary>
        /// Loads the profiles.
        /// </summary>
        private void LoadProfiles()
        {
            string errorMessage = fProfile.Instance.LoadProfiles();

            if (string.IsNullOrEmpty(errorMessage))
            {
                leProfiles.Properties.DataSource = fProfile.Instance.Profiles;
                leProfiles.EditValue = fProfile.Instance.Profiles.FirstOrDefault();
            }
        }

        /// <summary>
        /// Selects the first profile if possible.
        /// </summary>
        private void SelectFirstProfileIfPossible()
        {
            if (fProfile.Instance.Profiles.Count == 1 && fProfile.Instance.Profiles.FirstOrDefault() is SettingsProfile settingsProfile)
            {
                fProfile.Instance.ChangeProfile(settingsProfile);

                leProfiles.EditValue = null;
                leProfiles.EditValue = settingsProfile;
            }
        }

        /// <summary>
        /// Show the change dialog
        /// </summary>
        /// <param name="settingsProfile"></param>
        private void ShowProfileChangeDialog(SettingsProfile settingsProfile)
        {
            using fmProfileDetail profileDetailDialog = new(settingsProfile);

            if (profileDetailDialog.ShowDialog() == DialogResult.OK)
            {
                SelectFirstProfileIfPossible();
            }
        }
        #endregion

        #region Event handlers
        /// <summary>
        /// Handles the Click event of the btnAddProfile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnAddProfile_Click(object sender, EventArgs e)
        {
            using var profileSelectionDialog = new fmProfileDetail();

            if (profileSelectionDialog.ShowDialog() == DialogResult.OK && profileSelectionDialog.SettingsProfile != null)
            {
                fProfile.Instance.UpdateProfile(profileSelectionDialog.SettingsProfile);

                SelectFirstProfileIfPossible();
            }
        }

        /// <summary>
        /// Confirm selected profile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (leProfiles.EditValue is SettingsProfile settingsProfile)
            {
                fProfile.Instance.ChangeProfile(settingsProfile);

                DialogResult = DialogResult.OK;
            }
            else XtraMessageBox.Show("Není vybrán žádný profil, nelze pokračovat.", "Upozornění", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Handles the FormClosing event of the fmProfileSelection control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
        private void fmProfileSelection_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (fProfile.Instance.CurrentProfile == null)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Handles the ButtonClick event of the leProfiles control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraEditors.Controls.ButtonPressedEventArgs"/> instance containing the event data.</param>
        private void leProfiles_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gridLookUpEdit1View.GetFocusedRow() is SettingsProfile settingsProfile)
            {
                if (e.Button.Caption == gcEdit.Caption)
                {
                    ShowProfileChangeDialog(settingsProfile);
                }
                else if (e.Button.Caption == gcRemove.Caption)
                {
                    fProfile.Instance.RemoveProfile(settingsProfile);
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the btnCancel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}