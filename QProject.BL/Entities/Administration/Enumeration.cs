using QProject.Base;
using QProject.Shared.Attributes;

namespace QProject.BL.Entities.Administration
{
    [DatabaseTable(TableName = "enumerations")]
    public class Enumeration : Entity
    {
        #region Properties and fields
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string? Name { get; set; }
        #endregion
    }
}
