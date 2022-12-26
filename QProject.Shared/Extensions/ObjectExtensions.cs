using QProject.Shared.Interfaces;

namespace QProject.Shared.Extensions
{
    public static class ObjectExtensions
    {
        #region Methods
        /// <summary>
        /// Determines whether [is same as] [the specified second].
        /// </summary>
        /// <param name="first">The first.</param>
        /// <param name="second">The second.</param>
        /// <returns>
        ///   <c>true</c> if [is same as] [the specified second]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsSameAs(this object? first, object? second)
        {
            if (first == null && second != null)
                return false;

            if (second == null && first != null)
                return false;

            if (first == null && second == null)
                return true;

            if (first is decimal firstDecimal && second is decimal secondDecimal)
                return firstDecimal == secondDecimal;

            if (second.GetType() != first.GetType())
                return false;

            if (first is IEntity firstEntity && second is IEntity secondEntity)
                return firstEntity.Id == secondEntity.Id;

            return first.ToString() == second.ToString();
        }
        #endregion
    }
}
