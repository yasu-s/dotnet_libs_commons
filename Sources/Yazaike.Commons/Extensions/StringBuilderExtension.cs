namespace Yazaike.Commons.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// StringBuilder Extension Class
    /// </summary>
    public static class StringBuilderExtension
    {
        /// <summary>
        /// Appends the string returned by processing a composite format string, 
        /// which contains zero or more format items, to this instance. 
        /// Each format item is replaced by the string representation of a single argument.
        /// And appends the default line terminator to the end of the current StringBuilder object.
        /// </summary>
        /// <param name="builder">StringBuilder object.</param>
        /// <param name="format">A composite format string.</param>
        /// <param name="arg0">An object to format.</param>
        /// <returns>
        /// A reference to this instance with format appended.<br />
        /// Each format item in format is replaced by the string representation of arg0.
        /// </returns>
        public static StringBuilder AppendLine(this StringBuilder builder, string format, object arg0)
        {
            if (format == null) throw new ArgumentNullException("format is null.");

            return builder.AppendFormat(format, arg0).AppendLine();
        }

        /// <summary>
        /// Appends the string returned by processing a composite format string, 
        /// which contains zero or more format items, to this instance. 
        /// Each format item is replaced by the string representation of a corresponding argument in a parameter array.
        /// And appends the default line terminator to the end of the current StringBuilder object.
        /// </summary>
        /// <param name="builder">StringBuilder object.</param>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">An array of objects to format.</param>
        /// <returns>
        /// A reference to this instance with format appended.<br />
        /// Each format item in format is replaced by the string representation of the corresponding object argument.
        /// </returns>
        public static StringBuilder AppendLine(this StringBuilder builder, string format, params object[] args)
        {
            if (format == null) throw new ArgumentNullException("format is null.");
            if (args == null) throw new ArgumentNullException("args is null.");

            return builder.AppendFormat(format, args).AppendLine();
        }
    }
}
