using QProject.Base.DatabaseConnection;
using Shared.Attributes;
using SqlKata;
using SqlKata.Execution;
using System.Reflection;

namespace QProject.Base
{
    public class EntityManager
    {
        /// <summary>
        /// Produces the entity.
        /// </summary>
        /// <typeparam name="EntityType">The type of the ntity type.</typeparam>
        /// <returns></returns>
        public static EntityType ProduceEntity<EntityType>() where EntityType : Entity
        {
            EntityType instance = Activator.CreateInstance<EntityType>();
            instance.properties.ForEach(property => property.IsInitialized = true);
            return instance;
        }

        /// <summary>
        /// Rollbacks the entity.
        /// </summary>
        public static void RollbackEntity<EntityType>(EntityType instance) where EntityType : Entity
        {
            if (instance.IsSaved)
            {
                foreach (EntityProperty property in instance.properties)
                {
                    property.Rollback();
                }

                instance.IsModified = false;
                instance.IsDeleted = false;
            }
            else
            {
                DeleteEntity(instance);
            }
        }

        /// <summary>
        /// Saves the entity.
        /// </summary>
        /// <typeparam name="EntityType">The type of the ntity type.</typeparam>
        /// <param name="instance">The instance.</param>
        public static void SaveEntity<EntityType>(EntityType instance) where EntityType : Entity
        {
            IEnumerable<KeyValuePair<string, object>> changedProperties = GetChangedProperties(instance, onlyModified: instance.IsSaved);

            Query? query = DBConn.Instance.CreateQuery<EntityType>();

            if (query != null)
            {
                if (instance.IsSaved)
                {
                    query.Where(nameof(Entity.Id), instance.Id).Update(changedProperties);
                }
                else
                {
                    instance.Id = query.Where(nameof(Entity.Id), instance.Id).InsertGetId<int>(changedProperties);
                }

                instance.IsModified = false;
                instance.SaveProperties();
            }
        }

        /// <summary>
        /// Deletes the entity.
        /// </summary>
        public static void DeleteEntity<EntityType>(EntityType instance) where EntityType : Entity
        {
            DBConn.Instance.Delete<EntityType>(instance.Id);

            instance.properties.Clear();
            instance.IsDeleted = true;
        }

        /// <summary>
        /// Gets the changed properties.
        /// </summary>
        /// <typeparam name="EntityType">The type of the ntity type.</typeparam>
        /// <param name="instance">The instance.</param>
        /// <returns></returns>
        private static IEnumerable<KeyValuePair<string, object>> GetChangedProperties<EntityType>(EntityType instance, bool onlyModified = false)
            where EntityType : Entity
        {
            foreach (PropertyInfo propertyInfo in instance.GetType().GetProperties())
            {
                DatabaseColumn? columnAttribute = propertyInfo.GetCustomAttribute<DatabaseColumn>();

                if (!(columnAttribute?.ReadOnly ?? false))
                {
                    EntityProperty? engineProperty = instance.properties.FirstOrDefault(p => p.Name == propertyInfo.Name);

                    if ((engineProperty?.IsModified ?? true) || !onlyModified)
                    {
                        object? propertyValue = propertyInfo.GetValue(instance);

                        if (propertyValue != null)
                            yield return new KeyValuePair<string, object>(propertyInfo.Name, propertyValue);
                    }
                }
            }
        }
    }
}
