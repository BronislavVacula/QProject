namespace QProject.Base.Helpers
{
    public static class StringHelpers
    {
        /// <summary>
        /// Gets the length character text.
        /// </summary>
        /// <param name="length">The length.</param>
        /// <returns></returns>
        public static string GetLengthCharacterText(int length)
        {
            return length switch
            {
                0 => "znak",
                2 or 3 or 4 => "znaky",
                _ => "znaků",
            };
        }
    }
}
