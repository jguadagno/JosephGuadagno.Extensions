using System;

namespace JosephGuadagno.Extensions.Types
{
    /// <summary>
    /// Extensions for the <see cref="DateTime"/> object
    /// </summary>
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Returns a formatted date.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="format"></param>
        /// <returns>Returns a formatted date time string. If the value is null, null will be returned.</returns>
        public static string ToFormattedStringValue(this DateTime? value, string format)
        {
            return value?.ToString(format);
        }
    }
}