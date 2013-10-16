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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="arg0"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static bool Or(this string value, string arg0, params string[] args)
        {
            if (value.Equals(arg0)) return true;
            if (args == null) return false;

            foreach (string str in args)
            {
                if (value.Equals(str))
                    return true;
            }

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="arg0"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static bool And(this string value, string arg0, params string[] args)
        {
            if (!value.Equals(arg0)) return false;

            foreach (string str in args)
            {
                if (!value.Equals(str))
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Converts the string representation of a number to its 16-bit signed integer equivalent.
        /// </summary>
        /// <param name="value">
        /// A string containing a number to convert. 
        /// </param>
        /// <returns>
        /// A 16-bit signed integer equivalent to the number contained in value.
        /// </returns>
        public static short ToShort(this string value)
        {
            short result = 0;

            if (short.TryParse(value, out result))
                return result;
            else
                throw new FormatException("value is not in the correct format.");
        }

        /// <summary>
        /// Converts the string representation of a number to its 32-bit signed integer equivalent.
        /// </summary>
        /// <param name="value">
        /// A string containing a number to convert. 
        /// </param>
        /// <returns>
        /// A 32-bit signed integer equivalent to the number contained in value.
        /// </returns>
        public static int ToInt(this string value)
        {
            int result = 0;

            if (int.TryParse(value, out result))
                return result;
            else
                throw new FormatException("value is not in the correct format.");
        }

        /// <summary>
        /// Converts the string representation of a number to its 64-bit signed integer equivalent.
        /// </summary>
        /// <param name="value">
        /// A string containing a number to convert. 
        /// </param>
        /// <returns>
        /// A 64-bit signed integer equivalent to the number contained in value.
        /// </returns>
        public static long ToLong(this string value)
        {
            long result = 0;

            if (long.TryParse(value, out result))
                return result;
            else
                throw new FormatException("value is not in the correct format.");
        }

        /// <summary>
        /// Converts the string representation of a number to its double-precision floating-point number equivalent.
        /// </summary>
        /// <param name="value">
        /// A string that contains a number to convert. 
        /// </param>
        /// <returns>
        /// A double-precision floating-point number that is equivalent to the numeric value or symbol specified in value.
        /// </returns>
        public static double ToDouble(this string value)
        {
            double result = 0;

            if (double.TryParse(value, out result))
                return result;
            else
                throw new FormatException("value is not in the correct format.");
        }

        /// <summary>
        /// Converts the string representation of a number to its Decimal equivalent.
        /// </summary>
        /// <param name="value">
        /// The string representation of the number to convert.
        /// </param>
        /// <returns>
        /// The equivalent to the number contained in value.
        /// </returns>
        public static decimal ToDecimal(this string value)
        {
            decimal result = 0;

            if (decimal.TryParse(value, out result))
                return result;
            else
                throw new FormatException("value is not in the correct format.");
        }

        /// <summary>
        /// Converts the specified string representation of a logical value to its Boolean equivalent, or throws an exception 
        /// if the string is not equivalent to the value of Boolean.TrueString or Boolean.FalseString.
        /// </summary>
        /// <param name="value">
        /// A string containing the value to convert. 
        /// </param>
        /// <returns>
        /// true if value is equivalent to the value of the Boolean.TrueString field.<br /> 
        /// false if value is equivalent to the value of the Boolean.FalseString field.
        /// </returns>
        public static bool ToBool(this string value)
        {
            bool result = false;

            if (bool.TryParse(value, out result))
                return result;
            else
                throw new FormatException("value is not in the correct format.");
        }

        /// <summary>
        /// Converts the specified string representation of a date 
        /// and time to its DateTime equivalent and returns a value that indicates 
        /// whether the conversion succeeded.
        /// </summary>
        /// <param name="value">
        /// A string containing the value to convert. 
        /// </param>
        /// <returns>
        /// true if the s parameter was converted successfully<br />
        /// otherwise, false.
        /// </returns>
        public static DateTime ToDateTime(this string value)
        {
            DateTime result;

            if (DateTime.TryParse(value, out result))
                return result;
            else
                throw new FormatException("value is not in the correct format.");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <param name="ci"></param>
        /// <param name="option"></param>
        /// <returns></returns>
        public static bool EqualsEx(this string source, string target, CompareInfo ci, CompareOptions options)
        {
            if (ci == null) throw new ArgumentNullException("ci is null.");

            return (ci.Compare(source, target, options) == 0);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static bool EqualsEx(this string source, string target)
        {
            return source.EqualsEx(target, CultureInfo.CurrentCulture.CompareInfo, CompareOptions.None);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static bool EqualsEx(this string source, string target, CompareOptions options)
        {
            return source.EqualsEx(target, CultureInfo.CurrentCulture.CompareInfo, options);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static byte[] GetBytes(this string value)
        {
            return value.GetBytes(Encoding.Unicode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static byte[] GetBytes(this string value, Encoding encoding)
        {
            if (encoding == null) throw new ArgumentNullException("encoding is null.");

            return encoding.GetBytes(value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int GetByteSize(this string value)
        {
            return value.GetByteSize(Encoding.Unicode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static int GetByteSize(this string value, Encoding encoding)
        {
            if (encoding == null) throw new ArgumentNullException("encoding is null.");

            return value.GetBytes(encoding).Length;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsNull(this string value)
        {
            return value == null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="format"></param>
        /// <param name="arg0"></param>
        /// <returns></returns>
        public static string Format(this string format, object arg0)
        {
            return string.Format(format, arg0);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="format"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static string Format(this string format, params object[] args)
        {
            return string.Format(format, args);
        }

    }
}
