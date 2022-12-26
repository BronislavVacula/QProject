namespace QProject.BL.Entities.Settings
{
    public abstract class ServerSettings
    {
        #region Properties and fields
        public string? Server { get; set; }
        public uint? Port { get; set; }

        public string? Username { get; set; }
        public string? Password { get; set; }
        #endregion
    }
}
