using QProject.Base.Constants;
using QProject.BL.Entities.Settings;
using System.Xml.Serialization;

namespace QProject.BL.Facade.Administration
{
    public class fProfile
    {
        #region Singleton        
        /// <summary>
        /// The instance
        /// </summary>
        private static fProfile? instance;

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>
        /// The instance.
        /// </value>
        public static fProfile Instance => instance ??= new fProfile();

        /// <summary>
        /// Prevents a default instance of the <see cref="fProfile"/> class from being created.
        /// </summary>
        private fProfile() { }
        #endregion

        #region Properties and fields                
        /// <summary>
        /// Gets the current profile.
        /// </summary>
        /// <value>
        /// The current profile.
        /// </value>
        public SettingsProfile? CurrentProfile { get; private set; }

        /// <summary>
        /// The profiles
        /// </summary>
        public List<SettingsProfile> Profiles { get; private set; } = new();
        #endregion

        #region Methods               
        /// <summary>
        /// Loads the profiles.
        /// </summary>
        public string LoadProfiles()
        {
            XmlSerializer serializer = new(Profiles.GetType());

            try
            {
                if (File.Exists(ApplicationConstants.PROFILE_FILE_PATH))
                {
                    using var fs = new StreamReader(ApplicationConstants.PROFILE_FILE_PATH);

                    object? deserializedObject = serializer.Deserialize(fs);
                    if (deserializedObject != null)
                    {
                        Profiles = (List<SettingsProfile>)deserializedObject;
                    }
                    else Profiles = new List<SettingsProfile>();
                }
            }
            catch (Exception ex)
            {
                Profiles = new List<SettingsProfile>();

                return ex.Message;
            }

            return string.Empty;
        }

        /// <summary>
        /// Saves the profiles.
        /// </summary>
        /// <param name="profiles">The profiles.</param>
        public string SaveProfiles()
        {
            XmlSerializer serializer = new(Profiles.GetType());

            try
            {
                using var fs = new StreamWriter(ApplicationConstants.PROFILE_FILE_PATH);

                serializer.Serialize(fs, Profiles);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            return string.Empty;
        }

        /// <summary>
        /// Updates the profile.
        /// </summary>
        /// <param name="profile">The profile.</param>
        public void UpdateProfile(SettingsProfile profile)
        {
            SettingsProfile? foundProfile = Profiles.FirstOrDefault(p => p?.Name == profile.Name);

            if (foundProfile == null)
            {
                Profiles.Add(profile);
            }
            else if (foundProfile.GetHashCode() != profile.GetHashCode())
            {
                foundProfile.Update(profile);
            }
        }

        /// <summary>
        /// Changes the profile.
        /// </summary>
        /// <param name="profile">The profile.</param>
        public void ChangeProfile(SettingsProfile profile)
        {
            CurrentProfile = profile;
        }

        /// <summary>
        /// Removes the profile.
        /// </summary>
        /// <param name="settingsProfile">The settings profile.</param>
        public void RemoveProfile(SettingsProfile settingsProfile)
        {
            if (Profiles.Contains(settingsProfile))
                Profiles.Remove(settingsProfile);
        }

        /// <summary>
        /// Determines whether this instance [can create profile] the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>
        ///   <c>true</c> if this instance [can create profile] the specified name; otherwise, <c>false</c>.
        /// </returns>
        public bool CanCreateProfile(string name)
        {
            return !Profiles.Any(p => p.Name == name);
        }
        #endregion
    }
}
