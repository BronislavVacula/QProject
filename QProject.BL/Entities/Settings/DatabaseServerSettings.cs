using MySql.Data.MySqlClient;

namespace QProject.BL.Entities.Settings
{
    public class DatabaseServerSettings : ServerSettings
    {
        #region Properties and fields
        /// <summary>
        /// Gets or sets the name of the database.
        /// </summary>
        /// <value>
        /// The name of the database.
        /// </value>
        public string? DatabaseName { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Gets the connection string
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return new MySqlConnectionStringBuilder()
            {
                Server = Server,
                Port = Port ?? 3306,
                UserID = Username,
                Password = Password,
                Database = DatabaseName,
            }.GetConnectionString(true);
        }
        #endregion
    }
}
