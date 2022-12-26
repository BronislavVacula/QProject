using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;

namespace QProject.Classes.Validation
{
    public abstract class ValidatorRule
    {
        #region Proeprties and fields        
        /// <summary>
        /// Gets or sets the error text (Text showed up in the control tooltip).
        /// </summary>
        /// <value>
        /// The error text.
        /// </value>
        public virtual string ErrorText { get; set; } = "Neplatná hodnota";

        /// <summary>
        /// Gets or sets the type of the error.
        /// </summary>
        /// <value>
        /// The type of the error.
        /// </value>
        public virtual ErrorType ErrorType { get; set; } = ErrorType.Critical;
        #endregion

        #region Methods        
        /// <summary>
        /// Validates the control.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <returns></returns>
        public abstract bool ValidateControl(BaseEdit control);
        #endregion
    }
}
