using System;

namespace JosephGuadagno.Extensions.Types
{
    /// <summary>
    /// Extensions for the <see cref="int"/> object.
    /// </summary>
    public static class IntegerExtensions
    {
        /// <summary>
        /// Returns the int as a string
        /// </summary>
        /// <param name="value">The int</param>
        /// <param name="defaultReturn">The value to return if the int is null.</param>
        /// <returns>If the int is null, the value of <see cref="defaultReturn"/> will be returned.</returns>
        public static string ToStringValue(this int? value, string defaultReturn = null)
        {
            return value.HasValue ? value.ToString() : defaultReturn;
        }

        /// <summary>
        /// Converts the int to an item in the team enum
        /// </summary>
        /// <typeparam name="T">The enumeration</typeparam>
        /// <param name="value">The int</param>
        /// <returns>The eneration value</returns>
        public static T ToEnum<T>(this int? value)
        {
            return (T) Enum.Parse(typeof(T), (value ?? 0).ToString());
        }
    }
}