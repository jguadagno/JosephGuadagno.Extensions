namespace JosephGuadagno.Extensions
{
    /// <summary>
    /// Extensions for the <see cref="decimal"/> object
    /// </summary>
    public static class DecimalExtensions
    {
        /// <summary>
        /// Returns a string.
        /// </summary>
        /// <param name="value">The input</param>
        /// <param name="defaultReturn">The value to use if the <see cref="value"/> is null.</param>
        /// <returns>The decimal as a string if not null.  If null, the value of <see cref="defaultReturn"/></returns>
        public static string ToStringValue(this decimal? value, string defaultReturn = null)
        {
            return value.HasValue ? value.ToString() : defaultReturn;
        }
    }
}