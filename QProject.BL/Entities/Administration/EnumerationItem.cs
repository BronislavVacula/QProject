using QProject.Base;
using QProject.Shared.Attributes;

namespace QProject.BL.Entities.Administration
{
    [DatabaseTable(TableName = "enumerations_items", ViewName = "vEnumerations_items")]
    public class EnumerationItem : Entity
    {
        #region Properties and fields
        /// <summary>
        /// Gets or sets the enumeration identifier.
        /// </summary>
        /// <value>
        /// The enumeration identifier.
        /// </value>
        public int? EnumerationId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public string? Value { get; set; }

        /// <summary>
        /// Gets or sets the name of the enumeration.
        /// </summary>
        /// <value>
        /// The name of the enumeration.
        /// </value>
        public string? EnumerationName { get; set; }
        #endregion
    }
}
