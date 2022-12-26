using QProject.Base;

namespace QProject.Classes.ChangeTrack
{
    public class ChangeTracker<TEntity> where TEntity : Entity
    {
        #region Properties and fields
        /// <summary>
        /// The bindings
        /// </summary>
        private readonly List<ChangeTrackerItem<TEntity>> bindings = new();
        #endregion

        #region Methods
        /// <summary>
        /// Binds the specified control.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="controlProperty">The control property.</param>
        /// <param name="entity">The entity.</param>
        /// <param name="entityProperty">The entity property.</param>
        /// <param name="bindedToEntity">if set to <c>true</c> [binded to entity].</param>
        /// <param name="changedProperties">The changed properties.</param>
        public void Bind(Control control, string controlProperty, TEntity entity, string entityProperty, bool bindedToEntity = false, params string[] changedProperties)
        {
            ChangeTrackerItem<TEntity> changeTrackerItem = new(control, controlProperty, entity, entityProperty, bindedToEntity, changedProperties);
            changeTrackerItem.PushValueIntoControl();

            bindings.Add(changeTrackerItem);
        }

        /// <summary>
        /// Determines whether [has entity changes].
        /// </summary>
        /// <returns>
        ///   <c>true</c> if [has entity changes]; otherwise, <c>false</c>.
        /// </returns>
        public bool HasEntityChanges()
        {
            foreach (ChangeTrackerItem<TEntity> item in bindings)
            {
                if (item.HasChanges())
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Gets the changed column values.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<KeyValuePair<string, object?>> GetChangedColumnValues()
        {
            foreach (ChangeTrackerItem<TEntity> item in bindings)
            {
                if (item.HasChanges())
                {
                    foreach(KeyValuePair<string, object?> columnValue in item.GetColumnValues())
                        yield return columnValue;
                }
            }
        }

        /// <summary>
        /// Rollbacks the changes.
        /// </summary>
        public void RollbackChanges()
        {
            foreach (ChangeTrackerItem<TEntity> item in bindings)
            {
                item.PushValueIntoControl();
            }
        }

        /// <summary>
        /// Saves the changes.
        /// </summary>
        public void SaveChanges()
        {
            foreach (ChangeTrackerItem<TEntity> item in bindings)
            {
                item.PushValueIntoEntity();
            }
        }

        /// <summary>
        /// Clears the bindings.
        /// </summary>
        public void ClearBindings()
        {
            bindings.Clear();
        }
        #endregion
    }
}
