using QProject.Shared.Attributes;
using System.ComponentModel;
using System.Reflection;

namespace QProject.Shared.Extensions
{
    public static class TypeExtensions
    {
        #region Methods
        /// <summary>Gets the attribute.</summary>
        /// <typeparam name="AttributeType">The type of the attribute.</typeparam>
        /// <param name="objectType">Type of the object.</param>
        /// <param name="value">The value.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        public static AttributeType? GetAttribute<AttributeType>(this Type objectType) where AttributeType : Attribute
        {
            if (objectType.GetCustomAttributes(typeof(AttributeType), true).FirstOrDefault() is AttributeType att)
            {
                return att;
            }

            return default;
        }

        /// <summary>Gets the attribute value.</summary>
        /// <typeparam name="TAttribute">The type of the attribute.</typeparam>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="prop">The property.</param>
        /// <param name="value">The value.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        public static TValue? GetAttributeValue<TAttribute, TValue>(this Type objectType, Func<TAttribute, TValue> value) where TAttribute : Attribute
        {
            if (objectType.GetCustomAttributes(typeof(TAttribute), true).FirstOrDefault() is TAttribute att)
            {
                return value(att);
            }

            return default;
        }

        /// <summary>
        /// Gets the description.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        public static string GetDescription<T>(this T source)
        {
            FieldInfo? fieldInfo = source?.GetType().GetField(source?.ToString() ?? "");

            if (fieldInfo != null)
            {
                DescriptionAttribute[] attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(
                    typeof(DescriptionAttribute), false);

                if (attributes != null && attributes.Length > 0) 
                    return attributes[0].Description;
            }

            return source?.ToString() ?? "";
        }

        /// <summary>
        /// Gets the enum description.
        /// </summary>
        /// <param name="enumValue">The enum value.</param>
        /// <returns></returns>
        public static string GetEnumDescription(this Enum enumValue)
        {
            FieldInfo? fieldInfo = enumValue.GetType().GetField(enumValue.ToString());

            if (fieldInfo != null)
            {
                DescriptionAttribute[] descriptionAttributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (descriptionAttributes.Length > 0)
                    return descriptionAttributes[0].Description;
            }

            return enumValue.ToString();
        }

        /// <summary>
        /// Gets the property value.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <returns></returns>
        public static object? GetPropertyValue(this object item, string propertyName)
        {
            PropertyInfo? property = item.GetType().GetProperty(propertyName);

            if (property != null)
            {
                return property.GetValue(item);
            }

            return null;
        }

        /// <summary>
        /// Sets the property value.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static void SetPropertyValue(this object item, string propertyName, object? value)
        {
            PropertyInfo? property = item.GetType().GetProperty(propertyName);

            if (property != null)
            {
                property.SetValue(item, value);
            }
        }

        /// <summary>
        /// Gets the table column attribute.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <returns></returns>
        public static DatabaseColumn? GetTableColumnAttribute(this object item, string propertyName)
        {
            PropertyInfo? property = item.GetType().GetProperty(propertyName);

            if (property != null)
            {
                return property.GetCustomAttribute<DatabaseColumn>();
            }

            return null;
        }
        #endregion
    }
}
