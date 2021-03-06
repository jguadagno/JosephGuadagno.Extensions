﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;

namespace JosephGuadagno.Extensions.Types
{
    /// <summary>
    /// String Extensions
    /// </summary>
    public static class StringExtensions
    {
        private const string NumericFormat = @"[^\d]";
        private const string PhoneFormat = @"(\d{3})(\d{3})(\d{4})";
        private const string SsnFormat = @"(\d{3})(\d{2})(\d{4})";

        /// <summary>
        /// Removes non-numeric characters from the string.
        /// </summary>
        /// <param name="input">The string to remove non-numeric characters from.</param>
        /// <returns>The stripped string.</returns>
        public static string StripNonNumeric(this string input)
        {
            return input == null ? null : Regex.Replace(input, NumericFormat, "");
        }

        /// <summary>
        /// Formats the string as a phone number.
        /// </summary>
        /// <param name="input">The string to format as a phone number.</param>
        /// <returns>The formatted string.</returns>
        public static string FormatAsPhone(this string input)
        {
            return input == null ? null : Regex.Replace(input, PhoneFormat, "($1) $2-$3");
        }

        /// <summary>
        /// Formats the string as a phone number.
        /// </summary>
        /// <param name="input">The string to format as a phone number.</param>
        /// <returns>The formatted string.</returns>
        public static string FormatAsSsn(this string input)
        {
            return string.IsNullOrEmpty(input) ? null : Regex.Replace(input, SsnFormat, "$1-$2-$3");
        }

        /// <summary>
        /// Determines whether the string is null of empty
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>
        /// 	<c>true</c> if the string is empty of null; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsNullOrEmpty(this string text)
        {
            return string.IsNullOrEmpty(text);
        }

        /// <summary>
        /// Returns the given string truncated to the specified length, suffixed with the given value
        /// </summary>
        /// <param name="input"></param>
        /// <param name="length">Maximum length of return string</param>
        /// <param name="suffix">The value to suffix the return value with (if truncation is performed)</param>
        /// <returns></returns>
        public static string Truncate(this string input, int length, string suffix = "...")
        {
            if (input == null) return "";
            if (input.Length <= length) return input;

            if (suffix == null) suffix = "...";

            return input.Substring(0, length - suffix.Length) + suffix;
        }

        /// <summary>
        /// Splits a given string into an array based on character line breaks
        /// </summary>
        /// <param name="input"></param>
        /// <returns>String array, each containing one line</returns>
        public static string[] ToLineArray(this string input)
        {
            return input == null ? new string[] {} : Regex.Split(input, "\r\n");
        }

        /// <summary>
        /// Splits a given string into a strongly-typed list based on character line breaks
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Strongly-typed string list, each containing one line</returns>
        public static List<string> ToLineList(this string input)
        {
            List<string> output = new List<string>();
            output.AddRange(input.ToLineArray());
            return output;
        }

        /// <summary>
        /// Replaces line breaks with self-closing HTML 'br' tags
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string ReplaceBreaksWithBR(this string input)
        {
            return String.Join("<br/>", input.ToLineArray());
        }

        /// <summary>
        /// Replaces any single apostrophes with two of the same
        /// </summary>
        /// <param name="input"></param>
        /// <returns>String</returns>
        public static string DoubleApostrophes(this string input)
        {
            return Regex.Replace(input, "'", "''");
        }

        /// <summary>
        /// Removes any HTML tags from the input string
        /// </summary>
        /// <param name="input"></param>
        /// <returns>String</returns>
        public static string StripHtml(this string input)
        {
            return Regex.Replace(input, @"<(style|script)[^<>]*>.*?</\1>|</?[a-z][a-z0-9]*[^<>]*>|<!--.*?-->", "");
        }

        /// <summary>
        /// Attempts to convert the string to an int.
        /// </summary>
        /// <param name="source">The source string.</param>
        /// <returns>If successful, the integer representation of the string, otherwise null.</returns>
        public static int? ToNullableInt(this string source)
        {
            int results;
            if (!int.TryParse(source, out results))
            {
                return null;
            }
            return results;
        }

        /// <summary>
        /// Attempts to convert the string to a long.
        /// </summary>
        /// <param name="source">The source string.</param>
        /// <returns>If successful, the long representation of the string, otherwise null.</returns>
        public static long? ToNullableLong(this string source)
        {
            long results;
            if (!long.TryParse(source, out results))
            {
                return null;
            }
            return results;
        }

        /// <summary>
        /// Attempts to convert the string to a DateTime.
        /// </summary>
        /// <param name="source">The source string.</param>
        /// <returns>If successful, the DateTime representation of the string, otherwise null.</returns>
        public static DateTime? ToNullableDateTime(this string source)
        {
            DateTime results;
            if (!DateTime.TryParse(source, out results))
            {
                return null;
            }
            return results;
        }

        /// <summary>
        /// Attempts to convert the string to a TimeSpan.
        /// </summary>
        /// <param name="source">The source string.</param>
        /// <returns>If successful, the TimeSpan representation of the string, otherwise null.</returns>
        public static TimeSpan? ToNullableTimeSpan(this string source)
        {
            TimeSpan time;
            if (TimeSpan.TryParse(source, out time))
                return time;
            return null;
        }

        /// <summary>
        /// Attempts to convert the string to a double.
        /// </summary>
        /// <param name="source">The source string.</param>
        /// <returns>If successful, the double representation of the string, otherwise null.</returns>
        public static double? ToNullableDouble(this string source)
        {
            double results;
            if (!Double.TryParse(source, out results))
            {
                return null;
            }
            return results;
        }

        /// <summary>
        /// Attempts to convert the string to a decimal.
        /// </summary>
        /// <param name="source">The source string.</param>
        /// <returns>If successful, the decimal representation of the string, otherwise null.</returns>
        public static decimal? ToNullableDecimal(this string source)
        {
            decimal results;
            if (!Decimal.TryParse(source, out results))
            {
                return null;
            }
            return results;
        }

        /// <summary>
        /// Attempts to convert the string to a boolean.
        /// </summary>
        /// <param name="source">The source string.</param>
        /// <returns>If successful, the boolean representation of the string, otherwise null.</returns>
        public static bool? ToNullableBool(this string source)
        {
            bool results;
            if (!bool.TryParse(source, out results))
            {
                return null;
            }
            return results;
        }

        /// <summary>
        /// Attempts to convert the string to a GUID.
        /// </summary>
        /// <param name="source">The source string.</param>
        /// <returns>If successful, the GUID representation of the string, otherwise null.</returns>
        public static Guid? ToNullableGuid(this string source)
        {
            Guid? results = null;
            if (!string.IsNullOrEmpty(source))
            {
                try
                {
                    results = new Guid(source);
                }
                catch (Exception)
                {
                    results = null;
                }
            }
            return results;
        }

        public static T? ToNullable<T>(this string source) where T : struct
        {
            var result = new T?();
            try
            {
                if (!string.IsNullOrEmpty(source) && source.Trim().Length > 0)
                {
                    var converter = TypeDescriptor.GetConverter(typeof(T));
                    result = (T?) converter.ConvertFrom(source);
                }
            }
            catch
            {
                // ignored
            }
            return result;
        }

        /// <summary>
        /// This removes characters that are invalid for xml encoding
        /// </summary>
        /// <param name="text">Text to be encoded.</param>
        /// <returns>Text with invalid xml characters removed.</returns>
        public static string ToSafeForXml(this string text)
        {
            // From xml spec valid chars:
            // #x9 | #xA | #xD | [#x20-#xD7FF] | [#xE000-#xFFFD] | [#x10000-#x10FFFF]
            // any Unicode character, excluding the surrogate blocks, FFFE, and FFFF.
            const string regularExpression = @"[^\x09\x0A\x0D\x20-\xD7FF\xE000-\xFFFD\x10000-x10FFFF]";
            return Regex.Replace(text, regularExpression, "");
        }


        public static TEnum GetEnum<TEnum>(this string value, string property = "Name")
        {
            return String.IsNullOrWhiteSpace(value)
                ? default(TEnum)
                : Enum.GetValues(typeof(TEnum))
                    .Cast<TEnum>()
                    .FirstOrDefault(x => x.GetAttributePropertyValue<DisplayAttribute, string>(property).Equals(value));
        }
    }
}