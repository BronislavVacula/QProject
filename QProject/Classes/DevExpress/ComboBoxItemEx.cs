namespace QProject.Classes.DevExpress
{
    public class ComboBoxItemEx
    {
        #region Properties and fields
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public object? Value { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; } = string.Empty;
        #endregion

        #region Constructor and initialization        
        /// <summary>
        /// Initializes a new instance of the <see cref="ComboBoxItemEx"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="name">The name.</param>
        public ComboBoxItemEx(object value, string name)
        {
            Value = value;
            Name = name;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString() => Name;
        #endregion
    }
}
