using System.Reflection;

namespace Shared.Helpers
{
    public class StringHelpers
    {
        /// <summary>
        /// Replaces the variables with values from data source.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns></returns>
        public static string ReplaceVariablesWithValuesFromDataSource(object? dataSource, string text)
        {
            string result = text;

            if (dataSource != null)
            {
                PropertyInfo[] pInfo = dataSource.GetType().GetProperties();

                if (pInfo != null)
                {
                    foreach (PropertyInfo property in pInfo)
                    {
                        string propertyName = property.Name.ToLower();
                        object? propertyValue = property.GetValue(dataSource);

                        result = result.Replace($"%{propertyName}%", propertyValue?.ToString() ?? "");
                    }
                }
            }

            return result;
        }
    }
}
