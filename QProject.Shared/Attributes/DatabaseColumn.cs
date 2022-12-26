namespace QProject.Shared.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class DatabaseColumn : Attribute
    {
        #region Properties and fields
        /// <summary>
        /// Gets or sets a value indicating whether [read only] (Property is used in the insert/update script).
        /// </summary>
        /// <value>
        ///   <c>true</c> if [read only]; otherwise, <c>false</c>.
        /// </value>
        public bool ReadOnly { get; set; } = false;
        #endregion
    }
}
