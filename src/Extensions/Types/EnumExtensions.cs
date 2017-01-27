using System;
using System.ComponentModel.DataAnnotations;

namespace JosephGuadagno.Extensions.Types
{
    /// <summary>
    /// Extensions for the <see cref="Enum"/> object
    /// </summary>
    public static class EnumExtensions
    {
        /// <summary>
        /// Gets the display name for the Enum element
        /// </summary>
        /// <param name="value">The enumeration value</param>
        /// <returns>The name of the enumeration</returns>
        public static string GetDisplayName(this Enum value)
        {
            return value.GetAttributePropertyValue<DisplayAttribute, string>("Name");
        }

        /// <summary>
        /// Converts the Enumeration element to an nullable int
        /// </summary>
        /// <param name="value">The enumeration value</param>
        /// <returns>An int? with the value</returns>
        public static int? ToNullableInt(this Enum value)
        {
            return Convert.ToInt32(value) == 0 ? null : (int?) Convert.ToInt32(value);
        }

        /// <summary>
        /// Converts the Enumeration element to an nullable long
        /// </summary>
        /// <param name="value">The enumeration value</param>
        /// <returns>A long? with the value</returns>
        public static long? ToNullableLong(this Enum value)
        {
            return Convert.ToInt64(value) == 0 ? null : (long?) Convert.ToInt64(value);
        }

        /// <summary>
        /// Converts the enumeration value to a string
        /// </summary>
        /// <param name="value">The enumeration value</param>
        /// <returns>The string </returns>
        public static string ToDbString(this Enum value)
        {
            return value.ToDbString(true);
        }

        /// <summary>
        /// Converts the enumeration value to a string
        /// </summary>
        /// <param name="value">The enumeration value</param>
        /// <param name="zeroAsNull">Indicates if the value is 0, return a null</param>
        /// <param name="defaultReturn">The return value to use if the enum value is zero</param>
        /// <returns>The string </returns>
        public static string ToDbString(this Enum value, bool zeroAsNull, string defaultReturn = "NULL")
        {
            var intValue = Convert.ToInt32(value);

            return intValue == 0 && zeroAsNull
                ? defaultReturn
                : intValue.ToString();
        }
    }
}