using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;

namespace QProject.Classes.Validation
{
    public class Validator
    {
        /// <summary>
        /// The error provider
        /// </summary>
        private readonly static DXErrorProvider errorProvider = new();

        /// <summary>
        /// Validates the control.
        /// </summary>
        /// <param name="editor">The editor.</param>
        /// <param name="rule">The rule.</param>
        public static bool ValidateControl(BaseEdit editor, ValidatorRule rule)
        {
            bool result = rule.ValidateControl(editor);

            if(!result)
            {
                errorProvider.SetError(editor, rule.ErrorText, rule.ErrorType);
            }

            return result;
        }

        /// <summary>
        /// Clears the validator errors.
        /// </summary>
        public static void ClearValidatorErrors()
        {
            errorProvider.ClearErrors();
        }
    }
}
