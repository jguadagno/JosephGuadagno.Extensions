namespace JosephGuadagno.Extensions
{
    /// <summary>
    /// Extensions for the <see cref="bool"/> object
    /// </summary>
    public static class BooleanExtensions
    {
        /// <summary>
        /// Determines if a nullable bool is true
        /// </summary>
        /// <param name="value"></param>
        /// <returns>True, if true, other false if null or false</returns>
        public static bool IsTrue(this bool? value)
        {
            return value ?? false;
        }

        /// <summary>
        /// Determines if a nullable bool is false
        /// </summary>
        /// <param name="value"></param>
        /// <returns>True if false, other false if null or true</returns>
        public static bool IsFalse(this bool? value)
        {
            return value == false;
        }

        /// <summary>
        /// Determines if a nullable bool is null
        /// </summary>
        /// <param name="value"></param>
        /// <returns>True if null, otherwise false</returns>
        public static bool IsNull(this bool? value)
        {
            return !value.HasValue;
        }

        /// <summary>
        /// "Translates" the bool value to an integer
        /// </summary>
        /// <param name="value"></param>
        /// <param name="trueValue">The value to use if the bool is true. Default = 1</param>
        /// <param name="falseValue">The value to use if the bool is false. Default = 0</param>
        /// <returns>Returns the value specified in <paramref name="trueValue"/> if the <paramref name="value"/> if true or the value of <paramref name="falseValue"/> if it is false.</returns>
        public static int ToIntValue(this bool value, int trueValue = 1, int falseValue = 0)
        {
            return value ? trueValue : falseValue;
        }

        /// <summary>
        /// "Translates" the nullable bool value to an integer
        /// </summary>
        /// <param name="value"></param>
        /// <param name="trueValue">The value to use if the bool is true. Default = 1</param>
        /// <param name="falseValue">The value to use if the bool is false. Default = 0</param>
        /// <returns>Returns the value specified in <paramref name="trueValue"/> if the <paramref name="value"/> if true or the value of <paramref name="falseValue"/> if it is false or null.</returns>
        public static int ToIntValue(this bool? value, int trueValue = 1, int falseValue = 0)
        {
            return value.HasValue ? value.Value ? trueValue : falseValue : falseValue;
        }

        /// <summary>
        /// Converts the nullable bool to a string using ToString
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Returns the value of ToString if the <paramref name="value"/> has value, if not null.</returns>
        public static string ToStringValue(this bool? value)
        {
            return value.HasValue ? value.ToString() : null;
        }

        /// <summary>
        /// "Translates" the nullable bool value to string
        /// </summary>
        /// <param name="value"></param>
        /// <param name="trueString">The value to use if the bool is true. Default = true</param>
        /// <param name="falseString">The value to use if the bool is false. Default = false</param>
        /// <returns>Returns the value specified in <paramref name="trueString"/> if the <paramref name="value"/> if true or the value of <paramref name="falseString"/> if it is false.</returns>
        public static string ToDbString(this bool value, string trueString = "true", string falseString = "false")
        {
            return value ? trueString: falseString;
        }

        /// <summary>
        /// "Translates" the nullable bool value to string
        /// </summary>
        /// <param name="value"></param>
        /// <param name="nullString"></param>
        /// <param name="trueString">The value to use if the bool is true. Default = true</param>
        /// <param name="falseString">The value to use if the bool is false. Default = false</param>
        /// <returns>Returns the value specified in <paramref name="trueString"/> if the <paramref name="value"/> if true, the value of <paramref name="falseString"/> if it is false, or the value of <paramref name="trueString"/> if it is null.</returns>
        public static string ToDbString(this bool? value, string nullString = "NULL", string trueString = "true", string falseString = "false")
        {
            return value == null
                ? nullString
                : value.Value
                    ? trueString
                    : falseString;
        }
    }
}