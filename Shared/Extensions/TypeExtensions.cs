using System.ComponentModel;
using System.Reflection;

namespace Shared.Extensions
{
    public static class TypeExtensions
    {
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
            var fieldInfo = enumValue.GetType().GetField(enumValue.ToString());

            var descriptionAttributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return descriptionAttributes.Length > 0 ? descriptionAttributes[0].Description : enumValue.ToString();
        }
    }
}
