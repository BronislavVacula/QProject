using QProject.Base.DatabaseConnection;
using QProject.Shared.Attributes;
using QProject.Shared.Extensions;
using QProject.Shared.Interfaces;
using SqlKata;
using System.ComponentModel;

namespace QProject.Base
{
    public class Entity : INotifyPropertyChanged, IEntity
    {
        #region Properties and fields
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        [Key]
        public int? Id { get; set; }

        /// <summary>
        /// Gets a value indicating whether this instance is saved.
        /// </summary>
        [DatabaseColumn(ReadOnly = true)]
        public bool IsSaved => Id.HasValue;

        /// <summary>
        /// Gets or sets a value indicating whether this instance is deleted.
        /// </summary>
        [DatabaseColumn(ReadOnly = true)]
        public bool IsDeleted { get; set; } = false;

        /// <summary>
        /// The related entities
        /// </summary>
        public List<Entity> relatedEntities = new();
        #endregion

        #region Events         
        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;
        #endregion

        #region Methods
        /// <summary>
        /// Copies this instance.
        /// </summary>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        public TResult Copy<TResult>() where TResult : Entity
        {
            return (TResult)MemberwiseClone();
        }

        /// <summary>
        /// Saves this instance.
        /// </summary>
        /// <param name="columnValues">The column values.</param>
        public void Save(IEnumerable<KeyValuePair<string, object>>? columnValues = null)
        {
            EntityManager.SaveEntity(this);
        }
        #endregion

        #region Related entities   
        /// <summary>
        /// Gets the related entity.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="entityId">The entity identifier.</param>
        /// <returns></returns>
        public TEntity? GetRelatedEntity<TEntity>(int? entityId) where TEntity : Entity
        {
            Entity? relatedEntity = relatedEntities.FirstOrDefault(e => e.Id == entityId && e.GetType() == typeof(TEntity));

            if (relatedEntity == null)
            {
                //Find item into database
                relatedEntity = DBConn.Instance.Find<TEntity>(entityId);

                //If item exists in the database, add him to cache
                if (relatedEntity != null)
                    relatedEntities.Add(relatedEntity);
            }

            return (TEntity?)relatedEntity;
        }

        /// <summary>
        /// Sets the related entity.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="value">The value.</param>
        /// <param name="idBefore">The identifier before.</param>
        /// <param name="sourceTargetProperies">The source target properies.</param>
        public void SetRelatedEntity<TEntity>(TEntity? value, int? idBefore, Dictionary<string, string> sourceTargetProperies) where TEntity : Entity
        {
            if (value == null)
            {
                //Remove item from the cache
                relatedEntities.RemoveAll(e => e.Id == idBefore && e.GetType() == typeof(TEntity));

                SetRelatedEntityPropertyValue(sourceTargetProperies, prop => null);
            }
            else if (!relatedEntities.Contains(value))
            {
                //Add item to cache
                if (!relatedEntities.Contains(value))
                    relatedEntities.Add(value);

                SetRelatedEntityPropertyValue(sourceTargetProperies, prop => value.GetPropertyValue(prop));
            }
        }

        /// <summary>
        /// Sets the property value.
        /// </summary>
        /// <param name="sourceTargetProperies">The source target properies.</param>
        /// <param name="valueSelector">The value selector.</param>
        private void SetRelatedEntityPropertyValue(Dictionary<string, string> sourceTargetProperies, Func<string, object?> valueSelector)
        {
            foreach (KeyValuePair<string, string> sourceTargetProperty in sourceTargetProperies)
            {
                this.SetPropertyValue(sourceTargetProperty.Value, valueSelector(sourceTargetProperty.Key));
            }
        }
        #endregion
    }
}
