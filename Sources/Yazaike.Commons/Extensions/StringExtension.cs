namespace Yazaike.Commons.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using Microsoft.VisualBasic;

    /// <summary>
    /// String Extension Class
    /// </summary>
    public static class StringExtension
    {
        /// <summary>
        /// Converts wide (full-width) characters in the string to narrow (half-width) characters.
        /// </summary>
        /// <param name="value">String expression to be converted.</param>
        /// <returns>Returns a string converted as specified.</returns>
        public static string ToNarrow(this string value)
        {
            return value.ToNarrow(CultureInfo.CurrentCulture.LCID);
        }

        /// <summary>
        /// Converts wide (full-width) characters in the string to narrow (half-width) characters.
        /// </summary>
        /// <param name="value">String expression to be converted.</param>
        /// <param name="localeID">The LocaleID value, if different from the system LocaleID value.</param>
        /// <returns>Returns a string converted as specified.</returns>
        public static string ToNarrow(this string value, int localeID)
        {
            return Strings.StrConv(value, VbStrConv.Narrow, localeID);
        }

        /// <summary>
        /// Converts narrow (half-width) characters in the string to wide (full-width) characters.
        /// </summary>
        /// <param name="value">String expression to be converted.</param>
        /// <returns>Returns a string converted as specified.</returns>
        public static string ToWide(this string value)
        {
            return value.ToWide(CultureInfo.CurrentCulture.LCID);
        }

        /// <summary>
        /// Converts wide (full-width) characters in the string to narrow (half-width) characters.
        /// </summary>
        /// <param name="value">String expression to be converted.</param>
        /// <param name="localeID">The LocaleID value, if different from the system LocaleID value.</param>
        /// <returns>Returns a string converted as specified.</returns>
        public static string ToWide(this string value, int localeID)
        {
            return Strings.StrConv(value, VbStrConv.Wide, localeID);
        }
    }
}
