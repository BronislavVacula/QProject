namespace QProject.BL.Entities.Settings
{
    public class SettingsProfile
    {
        #region Properties and fields        
        /// <summary>
        /// Gets or sets the name of the profile.
        /// </summary>
        /// <value>
        /// The name of the profile.
        /// </value>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the database server settings.
        /// </summary>
        /// <value>
        /// The database server settings.
        /// </value>
        public DatabaseServerSettings DatabaseServerSettings { get; set; } = new();

        /// <summary>
        /// Gets or sets the mail server settings.
        /// </summary>
        /// <value>
        /// The mail server settings.
        /// </value>
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
