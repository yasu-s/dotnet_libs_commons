namespace Yazaike.Commons.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Exception Extension Class
    /// </summary>
    public static class ExceptionExtension
    {
        /// <summary>
        /// Find 
        /// </summary>
        /// <typeparam name="T">Find Exception Type.</typeparam>
        /// <param name="ex">Exception object.</param>
        /// <returns></returns>
        public static Exception FindInnerException<T>(this Exception ex) where T : Exception
        {
            if (ex is T)
                return ex;
            else if (ex.InnerException == null)
                return null;
            else
                return FindInnerException<T>(ex.InnerException);
        }
    }
}
