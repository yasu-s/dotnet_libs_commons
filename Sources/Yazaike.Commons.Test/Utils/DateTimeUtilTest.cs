namespace Yazaike.Commons.Test.Utils
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Yazaike.Commons.Utils;

    /// <summary>
    /// UnitTest1 の概要の説明
    /// </summary>
    [TestClass]
    public class DateTimeUtilTest
    {
        [TestMethod]
        public void TestGetBeginningOfMonth()
        {
            DateTime value = DateTimeUtil.GetBeginningOfMonth(new DateTime(2013, 4, 2));
            Assert.AreEqual(new DateTime(2013, 4, 1), value);

            value = DateTimeUtil.GetBeginningOfMonth(new DateTime(2013, 4, 30));
            Assert.AreEqual(new DateTime(2013, 4, 1), value);

            value = DateTimeUtil.GetBeginningOfMonth(new DateTime(2013, 3, 31));
            Assert.AreEqual(new DateTime(2013, 3, 1), value);

            value = DateTimeUtil.GetBeginningOfMonth(new DateTime(2013, 3, 1));
            Assert.AreEqual(new DateTime(2013, 3, 1), value);


            value = DateTimeUtil.GetBeginningOfMonth(2013, 4);
            Assert.AreEqual(new DateTime(2013, 4, 1), value);

            value = DateTimeUtil.GetBeginningOfMonth(2013, 5);
            Assert.AreEqual(new DateTime(2013, 5, 1), value);
        }

        [TestMethod]
        public void TestGetEndOfMonth()
        {
            DateTime value = DateTimeUtil.GetEndOfMonth(new DateTime(2013, 4, 29));
            Assert.AreEqual(new DateTime(2013, 4, 30), value);

            value = DateTimeUtil.GetEndOfMonth(new DateTime(2013, 4, 1));
            Assert.AreEqual(new DateTime(2013, 4, 30), value);

            value = DateTimeUtil.GetEndOfMonth(new DateTime(2013, 5, 1));
            Assert.AreEqual(new DateTime(2013, 5, 31), value);

            value = DateTimeUtil.GetEndOfMonth(new DateTime(2012, 2, 1));
            Assert.AreEqual(new DateTime(2012, 2, 29), value);

            value = DateTimeUtil.GetEndOfMonth(new DateTime(2013, 2, 1));
            Assert.AreEqual(new DateTime(2013, 2, 28), value);


            value = DateTimeUtil.GetEndOfMonth(2013, 4);
            Assert.AreEqual(new DateTime(2013, 4, 30), value);

            value = DateTimeUtil.GetEndOfMonth(2013, 5);
            Assert.AreEqual(new DateTime(2013, 5, 31), value);

            value = DateTimeUtil.GetEndOfMonth(2012, 2);
            Assert.AreEqual(new DateTime(2012, 2, 29), value);

            value = DateTimeUtil.GetEndOfMonth(2013, 2);
            Assert.AreEqual(new DateTime(2013, 2, 28), value);
        }
    }
}
