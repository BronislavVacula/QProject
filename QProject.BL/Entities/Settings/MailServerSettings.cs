using QProject.Base.Interfaces;

namespace QProject.BL.Entities.Settings
{
    public class MailServerSettings : ServerSettings, ISmtpSettings
    {
        public bool EnableSSL { get; set; } = true;
        public string? SenderEmailAddress { get; set; }
    }
}
