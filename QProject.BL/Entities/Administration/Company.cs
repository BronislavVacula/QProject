using QProject.Base;
using QProject.Shared.Attributes;

namespace QProject.BL.Entities.Administration
{
    [DatabaseTable(TableName = "companies")]
    public class Company : EntityWithTS
    {
        #region Properties and fields
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets a value indicating whether this instance is customer.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is customer; otherwise, <c>false</c>.
        /// </value>
        public bool IsCustomer { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether this instance is supplier.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is supplier; otherwise, <c>false</c>.
        /// </value>
        public bool IsSupplier { get; set; } = false;
        #endregion

        #region Methods        
        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return Name;
        }
        #endregion
    }
}
