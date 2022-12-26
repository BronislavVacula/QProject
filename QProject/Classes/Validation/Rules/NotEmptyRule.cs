using DevExpress.XtraEditors;

namespace QProject.Classes.Validation.Rules
{
    /// <summary>
    /// Check if EditValue is not null or empty
    /// </summary>
    /// <seealso cref="QProject.Classes.Validation.ValidatorRule" />
    public class NotEmptyRule : ValidatorRule
    {
        #region Constructor and initialization
        /// <summary>
        /// Initializes a new instance of the <see cref="NotEmptyRule"/> class.
        /// </summary>
        public NotEmptyRule()
        {
            ErrorText = "Položka musí být vyplněna";
        }
        #endregion

        #region Methods
        /// <summary>
        /// Validates the control.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <returns></returns>
        public override bool ValidateControl(BaseEdit control)
        {
            if(control.EditValue != null)
            {
                if(control is TextEdit textEdit)
                {
                    return !string.IsNullOrEmpty(textEdit.EditValue.ToString());
                }

                return true;
            }

            return false;
        }
        #endregion
    }
}
