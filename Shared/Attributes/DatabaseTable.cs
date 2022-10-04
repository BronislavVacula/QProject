namespace Shared.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class DatabaseTable : Attribute
    {
        /// <summary>
        /// Gets or sets the name of the table.
        /// </summary>
        /// <value>
        /// The name of the table.
        /// </value>
        public string TableName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the name of the view.
        /// </summary>
        /// <value>
        /// The name of the view.
        /// </value>
        public string? ViewName { get; set; }
    }
}
