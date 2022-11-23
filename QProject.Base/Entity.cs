using Shared.Attributes;
using SqlKata;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace QProject.Base
{
    public class Entity : INotifyPropertyChanged
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
        /// Gets or sets a value indicating whether this instance is modified.
        /// </summary>
        [DatabaseColumn(ReadOnly = true)]
        public bool IsModified { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether this instance is deleted.
        /// </summary>
        [DatabaseColumn(ReadOnly = true)]
        public bool IsDeleted { get; set; } = false;

        /// <summary>
        /// The properties
        /// </summary>
        internal List<EntityProperty> properties = new();
        #endregion

        #region Events         
        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;
        #endregion

        #region Methods
        /// <summary>
        /// Creates the property.
        /// </summary>
        /// <typeparam name="PropertyType">The type of the roperty type.</typeparam>
        /// <param name="propertyName">Name of the method.</param>
        /// <param name="defaultValue">The default value.</param>
        public void CreateProperty<PropertyType>([CallerMemberName()] string propertyName = "", object? defaultValue = null)
        {
            properties.Add(new EntityProperty(propertyName, defaultValue));
        }

        /// <summary>
        /// Clears the properties.
        /// </summary>
        public void ClearProperties() => properties.Clear();

        /// <summary>
        /// Gets the property value.
        /// </summary>
        /// <typeparam name="PropertyType">The type of the roperty type.</typeparam>
        /// <param name="propertyName">Name of the method.</param>
        /// <returns></returns>
        public PropertyType? GetPropertyValue<PropertyType>([CallerMemberName()] string propertyName = "")
        {
            EntityProperty? property = properties.FirstOrDefault(p => p.Name == propertyName);

            if (property != null)
            {
                return (PropertyType?)property.Value;
            }
            
            throw new Exception($"Propery {propertyName} doesnt exists!");
        }

        /// <summary>
        /// Sets the property value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="propertyName">Name of the property.</param>
        public void SetPropertyValue(object? value, [CallerMemberName()] string propertyName = "")
        {
            EntityProperty? property = properties.FirstOrDefault(p => p.Name == propertyName);

            if (property != null)
            {
                if (property.IsInitialized && property.Value != property.SavedValue)
                {
                    IsModified = true;

                    property.IsModified = true;
                }
                else
                {
                    property.SavedValue = value;
                    property.IsInitialized = true;
                }

                property.Value = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            else throw new Exception($"Propery {propertyName} doesnt exists!");
        }

        /// <summary>
        /// Determines whether [is property modified] [the specified property name].
        /// </summary>
        /// <param name="propertyName">Name of the property.</param>
        public bool IsPropertyModified(string propertyName)
        {
            EntityProperty? property = properties.FirstOrDefault(p => p.Name == propertyName);

            return property?.IsModified ?? false;
        }

        /// <summary>
        /// Saves the properties.
        /// </summary>
        internal void SaveProperties()
        {
            foreach (EntityProperty property in properties)
            {
                property.SavedValue = property.Value;
                property.IsModified = false;
                property.IsInitialized = true;
            }
        }

        /// <summary>
        /// Saves this instance.
        /// </summary>
        public void Save()
        {
            EntityManager.SaveEntity(this);
        }
        #endregion
    }
}
