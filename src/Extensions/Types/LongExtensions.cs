using System;

namespace JosephGuadagno.Extensions.Types
{
    public static class LongExtensions
    {
        /// <summary>
        /// Returns the long as a string
        /// </summary>
        /// <param name="value">The int</param>
        /// <param name="defaultReturn">The value to return if the int is null.</param>
        /// <returns>If the long is null, the value of <see cref="defaultReturn"/> will be returned.</returns>
        public static string ToStringValue(this long? value, string defaultReturn = null)
        {
            return value?.ToString() ?? defaultReturn;
        }

        /// <summary>
        /// Converts the long to an item in the team enum
        /// </summary>
        /// <typeparam name="T">The enumeration</typeparam>
        /// <param name="value">The int</param>
        /// <returns>The eneration value</returns>
        public static T ToEnum<T>(this long value)
        {
            return (T) Enum.Parse(typeof(T), value.ToString());
        }

        /// <summary>
        /// Converts the long to an item in the team enum
        /// </summary>
        /// <typeparam name="T">The enumeration</typeparam>
        /// <param name="value">The int</param>
        /// <returns>The eneration value</returns>
        public static T ToEnum<T>(this long? value)
        {
            return (T) Enum.Parse(typeof(T), (value ?? 0).ToString());
        }
    }
}