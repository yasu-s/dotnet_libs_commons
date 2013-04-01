using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yazaike.Commons.Extensions
{
    /// <summary>
    /// Exception Extension Class
    /// </summary>
    public static class ExceptionExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ex"></param>
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
