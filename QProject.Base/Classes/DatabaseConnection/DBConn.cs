using SqlKata.Compilers;
using SqlKata.Execution;
using MySql.Data.MySqlClient;
using SqlKata;
using Shared.Extensions;
using Shared.Attributes;

namespace QProject.Base.DatabaseConnection
{
    public class DBConn
    {
        #region Singleton        
        /// <summary>
        /// The instance
        /// </summary>
        private static DBConn? instance;

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>
        /// The instance.
        /// </value>
        public static DBConn Instance => instance ??= new DBConn();

        /// <summary>
        /// Prevents a default instance of the <see cref="DBConn"/> class from being created.
        /// </summary>
        private DBConn() { }
        #endregion

        #region Properties and fields        
        /// <summary>
        /// The connection string
        /// </summary>
        private string _connectionString = string.Empty;
        #endregion

        #region Methods                        
        /// <summary>
        /// Initializes the specified connection string.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        public void Init(string connectionString)
        {
            _connectionString = connectionString;
        }

        /// <summary>
        /// Gets the first item which match the criteria
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="columnName">Name of the column.</param>
        /// <param name="value">The value.</param>
        /// <param name="op">The op.</param>
        /// <returns></returns>
        public TEntity? FirstOrDefault<TEntity>(string columnName, object value, string op = "") where TEntity : Entity
        {
            return CreateQuery<TEntity>()?.Where(columnName, op, value)?.FirstOrDefault<TEntity>();
        }

        /// <summary>
        /// Gets all entities.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <returns></returns>
        public IEnumerable<TEntity> GetAll<TEntity>() where TEntity : Entity
        {
            return CreateQuery<TEntity>()?.Get<TEntity>() ?? new List<TEntity>();
        }

        /// <summary>
        /// Finds the specified entity.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="entityId">The entity identifier.</param>
        public TEntity? Find<TEntity>(int? entityId) where TEntity : Entity
        {
            if (entityId.HasValue)
            {
                return CreateQuery<TEntity>()?.FirstOrDefault<TEntity>();
            }

            return null;
        }

        /// <summary>
        /// Deletes the specified entity.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="entityId">The entity identifier.</param>
        public bool Delete<TEntity>(int? entityId) where TEntity : Entity
        {
            if (entityId.HasValue)
            {
                return CreateQuery<TEntity>()?.Where(nameof(Entity.Id), entityId).Delete() > 0;
            }

            return false;
        }

        /// <summary>
        /// Gets the count.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="columnName">Name of the column.</param>
        /// <param name="value">The value.</param>
        /// <param name="op">The op.</param>
        /// <returns></returns>
        public int GetCount<TEntity>(string? columnName = null, object? value = null, string op = "=") where TEntity : Entity
        {
            if(string.IsNullOrEmpty(columnName))
            {
                return CreateQuery<TEntity>()?.Where(columnName, op, value).Count<int>() ?? 0;
            }

            return CreateQuery<TEntity>()?.Count<int>() ?? 0;
        }

        /// <summary>
        /// Gets the query factory.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <returns></returns>
        public Query? CreateQuery<TEntity>()
        {
            try
            {
                MySqlConnection mySqlConnection = new(_connectionString);
                mySqlConnection.Open();

                QueryFactory queryFactory = new(mySqlConnection, new MySqlCompiler());

                return queryFactory.Query(GetEntityTableName<TEntity>());
            }
            catch { }

            return null;
        }

        /// <summary>
        /// Gets the entity related database table.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <returns></returns>
        private string GetEntityTableName<TEntity>()
        {
            return typeof(TEntity).GetAttributeValue((DatabaseTable dt) => dt.TableName) ?? "";
        }
        #endregion
    }
}
