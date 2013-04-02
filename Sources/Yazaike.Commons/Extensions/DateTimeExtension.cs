namespace Yazaike.Commons.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Microsoft.VisualBasic;

    /// <summary>
    /// DateTime Extension Class
    /// </summary>
    public static class DateTimeExtension
    {
        /// <summary>
        /// Gets the first of the month.
        /// </summary>
        /// <param name="date">DateTime object.</param>
        /// <returns>the first of the month</returns>
        public static DateTime GetFirstOfMonth(this DateTime date)
        {
            return DateAndTime.DateSerial(date.Year, date.Month, 1);
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
                return DateAndTime.DateSerial(date.Year, date.Month + 1, 0);
        }
    }
}
