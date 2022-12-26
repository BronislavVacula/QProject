using QProject.Base.Interfaces;

namespace QProject.BL.Entities.Settings
{
    public class MailServerSettings : ServerSettings, ISmtpSettings
    {
        #region Properties and fields
        public bool EnableSSL { get; set; } = true;
        public string? SenderEmailAddress { get; set; }
        #endregion
    }
}
