namespace Yazaike.Commons.Utils
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// DateTime Utility Class
    /// </summary>
    public static class DateTimeUtil
    {
        /// <summary>
        /// Gets the beginning of the month.
        /// </summary>
        /// <param name="date">DateTime object.</param>
        /// <returns>the beginning of the month</returns>
        public static DateTime GetBeginningOfMonth(DateTime date)
        {
            return GetBeginningOfMonth(date.Year, date.Month);
        }

        /// <summary>
        /// Gets the beginning of the month.
        /// </summary>
        /// <param name="year">year</param>
        /// <param name="month">month</param>
        /// <returns>the beginning of the month</returns>
        public static DateTime GetBeginningOfMonth(int year, int month)
        {
            if ((year < DateTime.MinValue.Year) || (DateTime.MaxValue.Year < year))
                throw new ArgumentOutOfRangeException("value or the resulting DateTime is less than 1 or greater than 9999.");

            if ((month < DateTime.MinValue.Month) || (DateTime.MaxValue.Month < month))
                throw new ArgumentOutOfRangeException("value or the resulting DateTime is less than 1 or greater than 12.");
                
            return new DateTime(year, month, 1);
        }

        /// <summary>
        /// Gets the end of the month.
        /// </summary>
        /// <param name="date">DateTime object.</param>
        /// <returns>the end of the month</returns>
        public static DateTime GetEndOfMonth(DateTime date)
        {
            return GetEndOfMonth(date.Year, date.Month);
        }

        /// <summary>
        /// Gets the end of the month.
        /// </summary>
        /// <param name="year">year</param>
        /// <param name="month">month</param>
        /// <returns>the end of the month</returns>
        public static DateTime GetEndOfMonth(int year, int month)
        {
            if ((year < DateTime.MinValue.Year) || (DateTime.MaxValue.Year < year))
                throw new ArgumentOutOfRangeException("value or the resulting DateTime is less than 1 or greater than 9999.");

            if ((month < DateTime.MinValue.Month) || (DateTime.MaxValue.Month < month))
                throw new ArgumentOutOfRangeException("value or the resulting DateTime is less than 1 or greater than 12.");

            if ((DateTime.MaxValue.Year == year) && (DateTime.MaxValue.Month == month))
                return DateTime.MaxValue.Date;
            else
                return Microsoft.VisualBasic.DateAndTime.DateSerial(year, month + 1, 0);
        }

        /// <summary>
        /// Gets the beginning of the year.
        /// </summary>
        /// <param name="date">DateTime object.</param>
        /// <returns>the beginning of the year</returns>
        public static DateTime GetBeginningOfYear(DateTime date)
        {
            return GetBeginningOfYear(date.Year);
        }

        /// <summary>
        /// Gets the beginning of the year.
        /// </summary>
        /// <param name="year">year</param>
        /// <returns>the beginning of the year</returns>
        public static DateTime GetBeginningOfYear(int year)
        {
            if ((year < DateTime.MinValue.Year) || (DateTime.MaxValue.Year < year))
                throw new ArgumentOutOfRangeException("value or the resulting DateTime is less than 1 or greater than 9999.");

            return new DateTime(year, 1, 1);
        }

        /// <summary>
        /// Gets the end of the year.
        /// </summary>
        /// <param name="date">DateTime object.</param>
        /// <returns>the end of the year</returns>
        public static DateTime GetEndOfYear(DateTime date)
        {
            return GetEndOfYear(date.Year);
        }

        /// <summary>
        /// Gets the end of the year.
        /// </summary>
        /// <param name="year">year</param>
        /// <returns>the end of the year</returns>
        public static DateTime GetEndOfYear(int year)
        {
            if ((year < DateTime.MinValue.Year) || (DateTime.MaxValue.Year < year))
                throw new ArgumentOutOfRangeException("value or the resulting DateTime is less than 1 or greater than 9999.");

            return new DateTime(year, 12, 31);
        }

        /// <summary>
        /// Gets the beginning of the japan fiscal year.
        /// </summary>
        /// <param name="date">DateTime object.</param>
        /// <returns>the beginning of the japan fiscal year</returns>
        public static DateTime GetBeginningOfJapanFiscalYear(DateTime date)
        {
            return GetBeginningOfJapanFiscalYear(date.Year);
        }

        /// <summary>
        /// Gets the beginning of the japan fiscal year.
        /// </summary>
        /// <param name="year">year</param>
        /// <returns>the beginning of the japan fiscal year</returns>
        public static DateTime GetBeginningOfJapanFiscalYear(int year)
        {
            if ((year < DateTime.MinValue.Year) || (DateTime.MaxValue.Year < year))
                throw new ArgumentOutOfRangeException("value or the resulting DateTime is less than 1 or greater than 9999.");

            return new DateTime(year, 4, 1);
        }

        /// <summary>
        /// Gets the end of the japan fiscal year.
        /// </summary>
        /// <param name="date">DateTime object.</param>
        /// <returns>the end of the japan fiscal year</returns>
        public static DateTime GetEndOfJapanFiscalYear(DateTime date)
        {
            return new DateTime(date.Year, 3, 31);
        }

        /// <summary>
        /// Gets the end of the japan fiscal year.
        /// </summary>
        /// <param name="year">year</param>
        /// <returns>the end of the japan fiscal year</returns>
        public static DateTime GetEndOfJapanFiscalYear(int year)
        {
            if ((year < DateTime.MinValue.Year) || (DateTime.MaxValue.Year < year))
                throw new ArgumentOutOfRangeException("value or the resulting DateTime is less than 1 or greater than 9999.");

            return new DateTime(year, 3, 31);
        }

        /// <summary>
        /// Compares two instances of DateTime and returns an integer that indicates whether 
        /// the first instance is earlier than, the same as, or later than the second instance.
        /// </summary>
        /// <param name="t1">The first object to compare.</param>
        /// <param name="t2">The second object to compare.</param>
        /// <param name="compare">compare option.</param>
        /// <returns>A signed number indicating the relative values of t1 and t2.</returns>
        public static int Compare(DateTime t1, DateTime t2, DateTimeCompare compare)
        {
            DateTime time1, time2;

            switch (compare)
            {
                case DateTimeCompare.Year:
                    time1 = new DateTime(t1.Year, 1, 1);
                    time2 = new DateTime(t2.Year, 1, 1);
                    break;
                case DateTimeCompare.Month:
                    time1 = new DateTime(t1.Year, t1.Month, 1);
                    time2 = new DateTime(t2.Year, t2.Month, 1);
                    break;
                case DateTimeCompare.Day:
                    time1 = new DateTime(t1.Year, t1.Month, t1.Day);
                    time2 = new DateTime(t2.Year, t2.Month, t2.Day);
                    break;
                case DateTimeCompare.Hour:
                    time1 = new DateTime(t1.Year, t1.Month, t1.Day, t1.Hour, 0, 0);
                    time2 = new DateTime(t2.Year, t2.Month, t2.Day, t2.Hour, 0, 0);
                    break;
                case DateTimeCompare.Minute:
                    time1 = new DateTime(t1.Year, t1.Month, t1.Day, t1.Hour, t1.Month, 0);
                    time2 = new DateTime(t2.Year, t2.Month, t2.Day, t2.Hour, t2.Month, 0);
                    break;
                case DateTimeCompare.Second:
                    time1 = new DateTime(t1.Year, t1.Month, t1.Day, t1.Hour, t1.Month, t1.Second);
                    time2 = new DateTime(t2.Year, t2.Month, t2.Day, t2.Hour, t2.Month, t2.Second);
                    break;
                default:
                    throw new ArgumentException("compare is invalid.");
            }

            return DateTime.Compare(time1, time2);
        }

        /// <summary>
        /// Compares two instances of DateTime and returns an integer that indicates whether 
        /// the first instance is earlier than, the same as, or later than the second instance.
        /// </summary>
        /// <param name="t1">The first object to compare.</param>
        /// <param name="t2">The second object to compare.</param>
        /// <returns>A signed number indicating the relative values of t1 and t2.</returns>
        public static int Compare(DateTime t1, DateTime t2)
        {
            return Compare(t1, t2, DateTimeCompare.Second);
        }

        /// <summary>
        /// Returns a value indicating whether two instances of DateTime are equal.
        /// </summary>
        /// <param name="t1">The first object to compare.</param>
        /// <param name="t2">The second object to compare.</param>
        /// <param name="compare">compare option.</param>
        /// <returns>
        ///  true if the two values are equal<br />
        ///  otherwise, false.
        /// </returns>
        public static bool Equals(DateTime t1, DateTime t2, DateTimeCompare compare)
        {
            return Compare(t1, t2, compare) == 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <param name="compare"></param>
        /// <returns></returns>
        public static bool GreaterThan(DateTime t1, DateTime t2, DateTimeCompare compare)
        {
            return Compare(t1, t2, compare) > 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <param name="compare"></param>
        /// <returns></returns>
        public static bool GreaterThanOrEqual(DateTime t1, DateTime t2, DateTimeCompare compare)
        {
            return Compare(t1, t2, compare) >= 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <param name="compare"></param>
        /// <returns></returns>
        public static bool LessThan(DateTime t1, DateTime t2, DateTimeCompare compare)
        {
            return Compare(t1, t2, compare) < 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <param name="compare"></param>
        /// <returns></returns>
        public static bool LessThanOrEqual(DateTime t1, DateTime t2, DateTimeCompare compare)
        {
            return Compare(t1, t2, compare) <= 0;
        }
    }
}
