using DevExpress.XtraEditors;
using QProject.Base;
using QProject.Classes.DevExpress;
using QProject.Extensions;
using QProject.Shared.Attributes;
using QProject.Shared.Extensions;

namespace QProject.Classes.ChangeTrack
{
    public class ChangeTrackerItem<TEntity> where TEntity : Entity
    {
        #region Properties and fields
        /// <value>
        /// The binded control.
        /// </value>
        public Control Control { get; private set; }

        /// <value>
        /// The binded property.
        /// </value>
        public string ControlProperty { get; private set; }

        /// <value>
        /// The binded entity.
        /// </value>
        public TEntity Entity { get; private set; }

        /// <value>
        /// The binded entity property.
        /// </value>
        public string EntityProperty { get; private set; }

        /// <summary>
        /// Gets a value indicating whether this instance is binded to entity.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is binded to entity; otherwise, <c>false</c>.
        /// </value>
        public bool IsBindedToEntity { get; private set; } = false;

        /// <summary>
        /// Gets the changed properties.
        /// </summary>
        /// <value>
        /// The changed properties.
        /// </value>
        public string[] ChangedProperties { get; private set; }
        #endregion

        #region Constructor and initialization
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeTrackerItem{TEntity}" /> class.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="controlProperty">The control property.</param>
        /// <param name="entity">The entity.</param>
        /// <param name="entityPropertyName">Name of the entity property.</param>
        /// <param name="isBindedToEntity">if set to <c>true</c> [is binded to entity].</param>
        /// <param name="changedProperties">The changed properties.</param>
        public ChangeTrackerItem(Control control, string controlProperty, TEntity entity, string entityPropertyName, bool isBindedToEntity, string[] changedProperties)
        {
            Control = control;
            ControlProperty = controlProperty;
            Entity = entity;
            EntityProperty = entityPropertyName;
            IsBindedToEntity = isBindedToEntity;
            ChangedProperties = changedProperties;
        }
        #endregion

        #region Methods        
        /// <summary>
        /// Determines whether [is read only] - Is not includes in Insert/Update SQL scripts.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if [is read only]; otherwise, <c>false</c>.
        /// </returns>
        public bool IsReadOnly()
        {
            DatabaseColumn? databaseColumn = Entity.GetTableColumnAttribute(EntityProperty);

            return databaseColumn?.ReadOnly ?? false;
        }

        /// <summary>
        /// Determines whether this instance has changes.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance has changes; otherwise, <c>false</c>.
        /// </returns>
        public bool HasChanges()
        {
            object? controlValue = Control.GetPropertyValue(ControlProperty);
            object? entityValue = Entity.GetPropertyValue(EntityProperty);

            if (controlValue is ComboBoxItemEx comboItem)
                controlValue = comboItem.Value;

            return !controlValue.IsSameAs(entityValue);
        }

        /// <summary>
        /// Gets the column value.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<KeyValuePair<string, object?>> GetColumnValues()
        {
            PushValueIntoEntity();

            if (!IsReadOnly())
            {
                return new KeyValuePair<string, object?>[]{
                    new KeyValuePair<string, object?>(EntityProperty, Entity.GetPropertyValue(EntityProperty)) 
                };
            }
            else return GetChangedProperties();
        }

        /// <summary>
        /// Gets the changed properties.
        /// </summary>
        /// <returns></returns>
        private IEnumerable<KeyValuePair<string, object?>> GetChangedProperties()
        {
            if (ChangedProperties != null)
            {
                foreach (string changedProperty in ChangedProperties)
                {
                    yield return new KeyValuePair<string, object?>(changedProperty, Entity.GetPropertyValue(changedProperty));
                }
            }
        }

        /// <summary>
        /// Pushes the entity value into related control.
        /// </summary>
        public void PushValueIntoControl()
        {
            //Find related combo box item
            if (Control is ComboBoxEdit comboBoxEdit && comboBoxEdit.Properties.Items.Count > 0)
            {
                object? entityValue = Entity.GetPropertyValue(EntityProperty);

                comboBoxEdit.SelectedItem = comboBoxEdit.FindItem(entityValue);
            }
            else
            {
                Control.SetPropertyValue(ControlProperty, Entity.GetPropertyValue(EntityProperty));
            }
        }

        /// <summary>
        /// Pushes the value into entity.
        /// </summary>
        public void PushValueIntoEntity()
        {
            object? controlValue = Control.GetPropertyValue(ControlProperty);

            //ComboBoxItemEx is used only for UI, so sets related value to property
            if (controlValue is ComboBoxItemEx comboitem)
            {
                Entity.SetPropertyValue(EntityProperty, comboitem.Value);
            }
            else
            {
                Entity.SetPropertyValue(EntityProperty, controlValue);
            }
        }
        #endregion
    }
}
