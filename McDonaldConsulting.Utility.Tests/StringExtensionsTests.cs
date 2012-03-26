namespace McDonaldConsulting.Utility.Tests
{
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class StringExtensionsTests
    {
        private const string NullString = null;
        private static readonly string emptyString = string.Empty;
        private const string WhitespaceString = " \t \r \n ";
        private const string McDonald = "McDonald";

        [TestMethod]
        public void IsNullOrEmpty()
        {
            Assert.IsTrue(NullString.IsNullOrEmpty());
            Assert.IsTrue(emptyString.IsNullOrEmpty());
            Assert.IsFalse(WhitespaceString.IsNullOrEmpty());
            Assert.IsFalse(McDonald.IsNullOrEmpty());
        }

        [TestMethod]
        public void IsNotNullOrEmpty()
        {
            Assert.IsFalse(NullString.IsNotNullOrEmpty());
            Assert.IsFalse(emptyString.IsNotNullOrEmpty());
            Assert.IsTrue(WhitespaceString.IsNotNullOrEmpty());
            Assert.IsTrue(McDonald.IsNotNullOrEmpty());
        }

        [TestMethod]
        public void IsNullOrWhiteSpace()
        {
            Assert.IsTrue(NullString.IsNullOrWhiteSpace());
            Assert.IsTrue(emptyString.IsNullOrWhiteSpace());
            Assert.IsTrue(WhitespaceString.IsNullOrWhiteSpace());
            Assert.IsFalse(McDonald.IsNullOrWhiteSpace());
        }

        [TestMethod]
        public void IsNotNullOrWhiteSpace()
        {
            Assert.IsFalse(NullString.IsNotNullOrWhiteSpace());
            Assert.IsFalse(emptyString.IsNotNullOrWhiteSpace());
            Assert.IsFalse(WhitespaceString.IsNotNullOrWhiteSpace());
            Assert.IsTrue(McDonald.IsNotNullOrWhiteSpace());
        }

        [TestMethod]
        public void Join()
        {
            // Arrange
            object[] objects = { 1, 2, 3 };
            string[] strings = { "a", "b", "c" };
            var enumerable = new List<string> { "a", "b", "c" };

            // Act & Assert
            Assert.AreEqual("1,2,3", objects.Join(","));
            Assert.AreEqual("a+b+c", strings.Join("+"));
            Assert.AreEqual("a;b;c", enumerable.Join(";"));
        }

        [TestMethod]
        public void FormatWith()
        {
            Assert.AreEqual("1: a", "1: {0}".FormatWith("a"));
            Assert.AreEqual("2: a b", "2: {0} {1}".FormatWith("a", "b"));
        }
    }
}
