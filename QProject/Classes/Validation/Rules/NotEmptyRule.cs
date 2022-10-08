using DevExpress.XtraEditors;

namespace QProject.Classes.Validation.Rules
{
    public class NotEmptyRule : ValidatorRule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotEmptyRule"/> class.
        /// </summary>
        public NotEmptyRule()
        {
            ErrorText = "Položka musí být vyplněna";
        }

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
                    return string.IsNullOrEmpty(textEdit.EditValue.ToString());
                }

                return true;
            }

            return false;
        }
    }
}
