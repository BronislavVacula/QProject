namespace QProject.BL.Entities.Settings
{
    public class MailServerSettings : ServerSettings
    {
        public bool EnableSSL { get; set; } = true;
        public string? SenderEmailAddress { get; set; }
    }
}
