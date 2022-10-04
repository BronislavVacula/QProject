namespace QProject.Base
{
    internal class EntityProperty
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        internal string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets a value indicating whether this instance is saved.
        /// </summary>
        /// <value>
        internal bool IsSaved { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether this instance is modified.
        /// </summary>
        internal bool IsModified { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether this instance is initialized.
        /// </summary>
        internal bool IsInitialized { get; set; } = false;

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        internal object? Value { get; set; }

        /// <summary>
        /// Gets or sets the saved value.
        /// </summary>
        /// <value>
        /// The saved value.
        /// </value>
        internal object? SavedValue { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityProperty"/> class.
        /// </summary>
        public EntityProperty(string propertyName, object? value)
        {
            Name = propertyName;
            SavedValue = Value = value;
            IsModified = false;
        }

        /// <summary>
        /// Rollbacks this instance.
        /// </summary>
        public void Rollback()
        {
            Value = SavedValue;

            IsModified = false;
        }
    }
}
