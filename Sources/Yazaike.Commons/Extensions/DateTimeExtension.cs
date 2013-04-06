namespace Yazaike.Commons.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// DateTime Extension Class
    /// </summary>
    public static class DateTimeExtension
    {
        /// <summary>
        /// Gets the beginning of the month.
        /// </summary>
        /// <param name="date">DateTime object.</param>
        /// <returns>the beginning of the month</returns>
        public static DateTime GetBeginningOfMonth(this DateTime date)
        {
            return new DateTime(date.Year, date.Month, 1);
        }

        /// <summary>
        /// Gets the end of the month.
        /// </summary>
        /// <param name="date">DateTime object.</param>
        /// <returns>the end of the month</returns>
        public static DateTime GetEndOfMonth(this DateTime date)
        {
            if ((DateTime.MaxValue.Year == date.Year) && (DateTime.MaxValue.Month == date.Month))
                return DateTime.MaxValue.Date;
            else
                return Microsoft.VisualBasic.DateAndTime.DateSerial(date.Year, date.Month + 1, 0);
        }

        /// <summary>
        /// Gets the beginning of the year.
        /// </summary>
        /// <param name="date">DateTime object.</param>
        /// <returns>the beginning of the year</returns>
        public static DateTime GetBeginningOfYear(this DateTime date)
        {
            return new DateTime(date.Year, 1, 1);
        }

        /// <summary>
        /// Gets the end of the year.
        /// </summary>
        /// <param name="date">DateTime object.</param>
        /// <returns>the end of the year</returns>
        public static DateTime GetEndOfYear(this DateTime date)
        {
            return new DateTime(date.Year, 12, 31);
        }

        /// <summary>
        /// Gets the beginning of the japan fiscal year.
        /// </summary>
        /// <param name="date">DateTime object.</param>
        /// <returns>the beginning of the japan fiscal year</returns>
        public static DateTime GetBeginningOfJapanFiscalYear(this DateTime date)
        {
            return new DateTime(date.Year, 4, 1);
        }

        /// <summary>
        /// Gets the end of the japan fiscal year.
        /// </summary>
        /// <param name="date">DateTime object.</param>
        /// <returns>the end of the japan fiscal year</returns>
        public static DateTime GetEndOfJapanFiscalYear(this DateTime date)
        {
            return new DateTime(date.Year, 3, 31);
        }
    }
}
