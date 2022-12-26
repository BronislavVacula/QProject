namespace QProject.Base.Interfaces
{
    public interface ISmtpSettings
    {
        #region Properties and fields
        string? Server { get; }
        uint? Port { get; }

        string? Username { get; }
        string? Password { get; }

        bool EnableSSL { get; }
        string? SenderEmailAddress { get; }
        #endregion
    }
}
