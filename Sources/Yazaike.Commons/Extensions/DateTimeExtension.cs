namespace Yazaike.Commons.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Yazaike.Commons.Utils;

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
            return DateTimeUtil.GetBeginningOfMonth(date);
        }

        /// <summary>
        /// Gets the end of the month.
        /// </summary>
        /// <param name="date">DateTime object.</param>
        /// <returns>the end of the month</returns>
        public static DateTime GetEndOfMonth(this DateTime date)
        {
            return DateTimeUtil.GetEndOfMonth(date);
        }

        /// <summary>
        /// Gets the beginning of the year.
        /// </summary>
        /// <param name="date">DateTime object.</param>
        /// <returns>the beginning of the year</returns>
        public static DateTime GetBeginningOfYear(this DateTime date)
        {
            return DateTimeUtil.GetBeginningOfYear(date);
        }

        /// <summary>
        /// Gets the end of the year.
        /// </summary>
        /// <param name="date">DateTime object.</param>
        /// <returns>the end of the year</returns>
        public static DateTime GetEndOfYear(this DateTime date)
        {
            return DateTimeUtil.GetEndOfYear(date);
        }

        /// <summary>
        /// Gets the beginning of the japan fiscal year.
        /// </summary>
        /// <param name="date">DateTime object.</param>
        /// <returns>the beginning of the japan fiscal year</returns>
        public static DateTime GetBeginningOfJapanFiscalYear(this DateTime date)
        {
            return DateTimeUtil.GetBeginningOfJapanFiscalYear(date);
        }

        /// <summary>
        /// Gets the end of the japan fiscal year.
        /// </summary>
        /// <param name="date">DateTime object.</param>
        /// <returns>the end of the japan fiscal year</returns>
        public static DateTime GetEndOfJapanFiscalYear(this DateTime date)
        {
            return DateTimeUtil.GetEndOfJapanFiscalYear(date);
        }

        public static bool GreaterThan(this DateTime t1, DateTime t2, DateTimeCompare compare)
        {
            return DateTimeUtil.GreaterThan(t1, t2, compare);
        }

        public static bool GreaterThanOrEqual(DateTime t1, DateTime t2, DateTimeCompare compare)
        {
            return DateTimeUtil.GreaterThanOrEqual(t1, t2, compare);
        }

        public static bool LessThan(DateTime t1, DateTime t2, DateTimeCompare compare)
        {
            return DateTimeUtil.LessThan(t1, t2, compare);
        }

        public static bool LessThanOrEqual(DateTime t1, DateTime t2, DateTimeCompare compare)
        {
            return DateTimeUtil.LessThanOrEqual(t1, t2, compare);
        }
    }
}
