namespace QProject.BL.Entities.Settings
{
    public class SettingsProfile
    {
        #region Properties and fields
        public string? Name { get; set; }

        public DatabaseServerSettings DatabaseServerSettings { get; set; } = new();
        public MailServerSettings MailServerSettings { get; set; } = new();
        #endregion

        #region Methods        
        /// <summary>
        /// Updates by the specified settings profile.
        /// </summary>
        /// <param name="settingsProfile">The settings profile.</param>
        public void Update(SettingsProfile settingsProfile)
        {
            Name = settingsProfile.Name;
            DatabaseServerSettings = settingsProfile.DatabaseServerSettings;   
            MailServerSettings = settingsProfile.MailServerSettings;
        }
        #endregion
    }
}
