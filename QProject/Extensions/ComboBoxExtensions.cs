using DevExpress.XtraEditors;
using QProject.Base;
using QProject.Base.DatabaseConnection;
using QProject.BL.Entities.Administration;
using QProject.Classes.DevExpress;
using QProject.Shared.Extensions;
using QProject.Shared.Interfaces;

namespace QProject.Extensions
{
    public static class ComboBoxExtensions
    {
        #region Methods
        /// <summary>
        /// Loads the combo-box with enum.
        /// </summary>
        /// <typeparam name="TEnum">The type of the enum.</typeparam>
        /// <param name="comboBox">The combo box.</param>
        /// <param name="selectedIndex">The selected index.</param>
        public static void LoadWithEnum<TEnum>(this ComboBoxEdit comboBox, int? selectedIndex = null) where TEnum : Enum
        {
            comboBox.Properties.Items.Clear();

            foreach (TEnum value in Enum.GetValues(typeof(TEnum)))
            {
                comboBox.Properties.Items.Add(new ComboBoxItemEx(value, value.GetEnumDescription()));
            }

            if (selectedIndex != null)
                comboBox.SelectedIndex = selectedIndex.Value;
        }

        /// <summary>
        /// Loads the combo box with enumeration.
        /// </summary>
        /// <param name="comboBox">The combo box.</param>
        /// <param name="enumerationCode">The enumeration code.</param>
        /// <param name="selectedIndex">The selected index.</param>
        public static void LoadWithEnumeration(this ComboBoxEdit comboBox, string enumerationCode, int? selectedIndex = null)
        {
            comboBox.Properties.Items.Clear();

            foreach (EnumerationItem enumerationItem in DBConn.Instance.GetWhere<EnumerationItem>(nameof(EnumerationItem.EnumerationName), enumerationCode, "=", true))
            {
                comboBox.Properties.Items.Add(new ComboBoxItemEx(enumerationItem, enumerationItem.Name));
            }

            if (selectedIndex.HasValue)
                comboBox.SelectedIndex = selectedIndex.Value;
        }

        /// <summary>
        /// Loads the combo box with entities.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="comboBox">The combo box.</param>
        /// <param name="entities">The entities.</param>
        public static void LoadWithEntities<TEntity>(this ComboBoxEdit comboBox, IEnumerable<TEntity> entities, Func<TEntity, string> itemNameSelector, int? selectedIndex = null) where TEntity : Entity
        {
            comboBox.Properties.Items.Clear();

            foreach (TEntity entity in entities)
            {
                comboBox.Properties.Items.Add(new ComboBoxItemEx(entity, itemNameSelector(entity)));
            }

            if (selectedIndex.HasValue)
                comboBox.SelectedIndex = selectedIndex.Value;
        }

        /// <summary>
        /// Loads the combo box with entities.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="comboBox">The combo box.</param>
        /// <param name="columnName">Name of the column.</param>
        /// <param name="value">The value.</param>
        /// <param name="op">The op.</param>
        public static void LoadWithEntities<TEntity>(this ComboBoxEdit comboBox, string columnName, object value, string op = "=", int? selectedIndex = null) where TEntity : Entity
        {
            comboBox.Properties.Items.Clear();

            IEnumerable<TEntity> entities = DBConn.Instance.GetWhere<TEntity>(columnName, value, op);

            if (entities != null)
            {
                foreach (TEntity entity in entities)
                {
                    comboBox.Properties.Items.Add(new ComboBoxItemEx(entity, entity?.ToString() ?? ""));
                }
            }

            if (selectedIndex.HasValue)
                comboBox.SelectedIndex = selectedIndex.Value;
        }

        /// <summary>
        /// Gets the selected item.
        /// </summary>
        /// <typeparam name="TItem">The type of the item.</typeparam>
        /// <param name="comboBox">The combo box.</param>
        /// <returns></returns>
        public static TItem? GetSelectedItem<TItem>(this ComboBoxEdit comboBox)
        {
            if (comboBox.EditValue is ComboBoxItemEx comboItem && comboItem.Value is TItem selectedItem)
            {
                return selectedItem;
            }

            return default;
        }

        /// <summary>
        /// Finds the item.
        /// </summary>
        /// <param name="comboBoxEdit">The combo box edit.</param>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static object? FindItem(this ComboBoxEdit comboBoxEdit, object? value)
        {
            foreach (object item in comboBoxEdit.Properties.Items)
            {
                if (item is ComboBoxItemEx comboItem)
                {
                    //Entity
                    if (value is IEntity sourceEntity)
                    {
                        bool areEntitiesSame = comboItem.Value is IEntity targetEntity && sourceEntity.Id == targetEntity.Id;

                        if (areEntitiesSame)
                            return item;
                    }
                    //Enums
                    else if (comboItem.Value is Enum sourceEnum)
                    {
                        bool areEnumsSame = value is Enum targetEnum && sourceEnum.ToString() == targetEnum.ToString();

                        if (areEnumsSame)
                            return item;
                    }

                    //Other
                    if (comboItem.Value == value)
                        return item;
                }
                else if (item == value)
                    return item;
            }

            return null;
        }
        #endregion
    }
}
