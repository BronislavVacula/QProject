using DevExpress.XtraEditors;
using Shared.Extensions;

namespace QProject.Extensions
{
    public static class ComboBoxExtensions
    {
        /// <summary>
        /// Loads the combo-box with enum.
        /// </summary>
        /// <typeparam name="TEnum">The type of the enum.</typeparam>
        /// <param name="comboBox">The combo box.</param>
        public static void LoadWithEnum<TEnum>(this ComboBoxEdit comboBox) where TEnum : Enum
        {
            comboBox.Properties.Items.Clear();

            foreach(TEnum value in Enum.GetValues(typeof(TEnum)))
            {
                comboBox.Properties.Items.Add(value.GetEnumDescription());
            }
        }
    }
}
