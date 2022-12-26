using DevExpress.XtraEditors;
using QProject.Base.Helpers;

namespace QProject.Classes.Validation.Rules
{
    /// <summary>
    /// Validate content length
    /// </summary>
    /// <seealso cref="QProject.Classes.Validation.ValidatorRule" />
    public class LengthRule : ValidatorRule
    {
        #region Proeprties and fields        
        /// <summary>
        /// Gets or sets the minimum length.
        /// </summary>
        /// <value>
        /// The minimum length.
        /// </value>
        public int? MinimumLength { get; set; }

        /// <summary>
        /// Gets or sets the maximum length.
        /// </summary>
        /// <value>
        /// The maximum length.
        /// </value>
        public int? MaximumLength { get; set; }
        #endregion

        #region Methods
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
        #endregion
    }
}
