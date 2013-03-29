namespace Yazaike.Commons.Test.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Yazaike.Commons.Extensions;

    /// <summary>
    /// StringExtensionTest の概要の説明
    /// </summary>
    [TestClass]
    public class StringExtensionTest
    {
        [TestMethod]
        public void TestToNarrow()
        {
            string value = "ＡＢＣ";
            Assert.AreEqual("ABC", value.ToNarrow());

            value = "ａｂｃ";
            Assert.AreEqual("abc", value.ToNarrow());

            value = "１２３４５６７８９０";
            Assert.AreEqual("1234567890", value.ToNarrow());

            value = "アイウエオ";
            Assert.AreEqual("ｱｲｳｴｵ", value.ToNarrow());

            value = "アイウエオ";
            Assert.AreEqual("ｱｲｳｴｵ", value.ToNarrow(CultureInfo.CurrentCulture.LCID));
        }

        [TestMethod]
        public void TestToWide()
        {
            string value = "ABC";
            Assert.AreEqual("ＡＢＣ", value.ToWide());

            value = "abc";
            Assert.AreEqual("ａｂｃ", value.ToWide());

            value = "1234567890";
            Assert.AreEqual("１２３４５６７８９０", value.ToWide());

            value = "ｱｲｳｴｵ";
            Assert.AreEqual("アイウエオ", value.ToWide());

            value = "ｱｲｳｴｵ";
            Assert.AreEqual("アイウエオ", value.ToWide(CultureInfo.CurrentCulture.LCID));
        }
    }
}
