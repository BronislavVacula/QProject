using QProject.Base.DatabaseConnection;
using QProject.Shared.Attributes;
using SqlKata.Execution;
using System.Reflection;

namespace QProject.Base
{
    public class EntityManager
    {
        #region Methods
        /// <summary>
        /// Saves the entity.
        /// </summary>
        /// <typeparam name="EntityType">The type of the ntity type.</typeparam>
        /// <param name="instance">The instance.</param>
        /// <param name="columnValues">The column values.</param>
        public static void SaveEntity<EntityType>(EntityType instance, IEnumerable<KeyValuePair<string, object>>? columnValues = null) where EntityType : Entity
        {
            //If column values are not defined, use all not read-only fields for the sql script
            columnValues ??= GetAllColumnValues(instance);

            if (instance.IsSaved)
            {
                //Run update script, only if there is any change
                if (columnValues != null && columnValues.Any())
                {
                    DBConn.Instance.CreateQuery<EntityType>()?.Where(nameof(Entity.Id), instance.Id).Update(columnValues);
                }
            }
            else
            {
                instance.Id = DBConn.Instance.CreateQuery<EntityType>()?.Where(nameof(Entity.Id), instance.Id)
                    .InsertGetId<int>(columnValues);
            }
        }

        /// <summary>
        /// Deletes the entity.
        /// </summary>
        /// <typeparam name="EntityType">The type of the ntity type.</typeparam>
        /// <param name="instance">The instance.</param>
        public static void DeleteEntity<EntityType>(EntityType instance) where EntityType : Entity
        {
            DBConn.Instance.Delete<EntityType>(instance.Id);

            instance.IsDeleted = true;
        }

        /// <summary>
        /// Gets the all column values for Insert script.
        /// </summary>
        /// <typeparam name="EntityType">The type of the ntity type.</typeparam>
        /// <param name="instance">The instance.</param>
        /// <returns></returns>
        private static IEnumerable<KeyValuePair<string, object>> GetAllColumnValues<EntityType>(EntityType instance)
            where EntityType : Entity
        {
            foreach (PropertyInfo propertyInfo in instance.GetType().GetProperties())
            {
                DatabaseColumn? columnAttribute = propertyInfo.GetCustomAttribute<DatabaseColumn>();

                if (!(columnAttribute?.ReadOnly ?? false))
                {
                    object? propertyValue = propertyInfo.GetValue(instance);

                    if (propertyValue != null)
                        yield return new KeyValuePair<string, object>(propertyInfo.Name, propertyValue);
                }
            }
        }
        #endregion
    }
}
