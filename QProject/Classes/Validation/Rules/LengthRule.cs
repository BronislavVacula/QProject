using DevExpress.XtraEditors;
using QProject.Base.Helpers;

namespace QProject.Classes.Validation.Rules
{
    public class LengthRule : ValidatorRule
    {
        public int? MinimumLength { get; set; } 
        public int? MaximumLength { get; set; }

        /// <summary>
        /// Validates the control.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <returns></returns>
        public override bool ValidateControl(BaseEdit control)
        {
            if(control.EditValue is string stringValue && !string.IsNullOrEmpty(stringValue))
            {
                if (MinimumLength.HasValue && stringValue.Length < MinimumLength.Value)
                {
                    ErrorText = $"Pole musí obsahovat minimálně {MinimumLength} " + StringHelpers.GetLengthCharacterText(MinimumLength.Value);
                    return false;
                }

                if(MaximumLength.HasValue && stringValue.Length > MaximumLength.Value)
                {
                    ErrorText = $"Pole může obsahovat maximálně {MinimumLength} " + StringHelpers.GetLengthCharacterText(MaximumLength.Value);
                    return false;
                }
            } 

            return MinimumLength.HasValue || MaximumLength.HasValue;
        }
    }
}
