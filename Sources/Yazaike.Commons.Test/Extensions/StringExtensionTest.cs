﻿namespace Yazaike.Commons.Test.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    
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

        [TestMethod]
        public void TestOr()
        {
            string value = "ABC";
            Assert.IsFalse(value.Or(null));
            Assert.IsFalse(value.Or(string.Empty));
            Assert.IsTrue(value.Or("ABC"));
            Assert.IsTrue(value.Or("abc", "ABC"));
            Assert.IsFalse(value.Or("abc", "123"));
            Assert.IsFalse(value.Or("abc", "ＡＢＣ", "１２３"));
            Assert.IsTrue(value.Or("abc", "ＡＢＣ", "ABC"));
        }

        [TestMethod]
        public void TestAnd()
        {
            string value = "ABC";
            Assert.IsFalse(value.And(null));
            Assert.IsFalse(value.And(string.Empty));
            Assert.IsTrue(value.And("ABC"));
            Assert.IsFalse(value.And("abc", "ABC"));
            Assert.IsFalse(value.And("abc", "123"));
            Assert.IsFalse(value.And("abc", "ＡＢＣ", "１２３"));
            Assert.IsFalse(value.And("abc", "ＡＢＣ", "ABC"));
            Assert.IsTrue(value.And("ABC", "ABC", "ABC"));
        }

        [TestMethod]
        public void TestGetByteSize()
        {
            Assert.AreEqual(1, "1".GetByteSize(Encoding.Default));
            Assert.AreEqual(2, "あ".GetByteSize(Encoding.Default));
            Assert.AreEqual(2, "1".GetByteSize(Encoding.Unicode));
            Assert.AreEqual(2, "あ".GetByteSize(Encoding.Unicode));
        }

        [TestMethod]
        public void TestIsNull()
        {
            string value = null;
            Assert.IsTrue(value.IsNull());

            value = "abc";
            Assert.IsFalse(value.IsNull());
        }

        [TestMethod]
        public void TestIsNullOrEmpty()
        {
            string value = null;
            Assert.IsTrue(value.IsNullOrEmpty());

            value = "abc";
            Assert.IsFalse(value.IsNullOrEmpty());

            value = string.Empty;
            Assert.IsTrue(value.IsNullOrEmpty());
        }

        [TestMethod]
        public void TestContainsNumber()
        {
            string value = "abc";
            Assert.IsFalse(value.ContainsNumber());

            value = "123";
            Assert.IsTrue(value.ContainsNumber());

            value = "123abc";
            Assert.IsTrue(value.ContainsNumber());

            value = "abc123";
            Assert.IsTrue(value.ContainsNumber());

            value = "abc123def";
            Assert.IsTrue(value.ContainsNumber());
        }

        [TestMethod]
        public void TestContainsAlphabet()
        {
            string value = "abc";
            Assert.IsTrue(value.ContainsAlphabet());

            value = "ABC";
            Assert.IsTrue(value.ContainsAlphabet());

            value = "123";
            Assert.IsFalse(value.ContainsAlphabet());

            value = "123abc";
            Assert.IsTrue(value.ContainsAlphabet());

            value = "ABC123";
            Assert.IsTrue(value.ContainsAlphabet());

            value = "abc123DEF";
            Assert.IsTrue(value.ContainsAlphabet());
        }
    }
}
