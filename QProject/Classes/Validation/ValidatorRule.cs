using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;

namespace QProject.Classes.Validation
{
    public abstract class ValidatorRule
    {
        public virtual string ErrorText { get; set; } = "Neplatná hodnota";
        public virtual ErrorType ErrorType { get; set; } = ErrorType.Critical;

        public abstract bool ValidateControl(BaseEdit control);
    }
}
