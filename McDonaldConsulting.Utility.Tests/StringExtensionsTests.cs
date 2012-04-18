namespace McDonaldConsulting.Utility.Tests
{
    using System.Collections.Generic;
    using Xunit;

    public class StringExtensionsTests
    {
        private const string NullString = null;
        private static readonly string emptyString = string.Empty;
        private const string WhitespaceString = " \t \r \n ";
        private const string McDonald = "McDonald";

        [Fact]
        public void IsNullOrEmpty()
        {
            Assert.True(NullString.IsNullOrEmpty());
            Assert.True(emptyString.IsNullOrEmpty());
            Assert.False(WhitespaceString.IsNullOrEmpty());
            Assert.False(McDonald.IsNullOrEmpty());
        }

        [Fact]
        public void IsNotNullOrEmpty()
        {
            Assert.False(NullString.IsNotNullOrEmpty());
            Assert.False(emptyString.IsNotNullOrEmpty());
            Assert.True(WhitespaceString.IsNotNullOrEmpty());
            Assert.True(McDonald.IsNotNullOrEmpty());
        }

        [Fact]
        public void IsNullOrWhiteSpace()
        {
            Assert.True(NullString.IsNullOrWhiteSpace());
            Assert.True(emptyString.IsNullOrWhiteSpace());
            Assert.True(WhitespaceString.IsNullOrWhiteSpace());
            Assert.False(McDonald.IsNullOrWhiteSpace());
        }

        [Fact]
        public void IsNotNullOrWhiteSpace()
        {
            Assert.False(NullString.IsNotNullOrWhiteSpace());
            Assert.False(emptyString.IsNotNullOrWhiteSpace());
            Assert.False(WhitespaceString.IsNotNullOrWhiteSpace());
            Assert.True(McDonald.IsNotNullOrWhiteSpace());
        }

        [Fact]
        public void Join()
        {
            // Arrange
            object[] objects = { 1, 2, 3 };
            string[] strings = { "a", "b", "c" };
            var enumerable = new List<string> { "a", "b", "c" };

            // Act & Assert
            Assert.Equal("1,2,3", objects.Join(","));
            Assert.Equal("a+b+c", strings.Join("+"));
            Assert.Equal("a;b;c", enumerable.Join(";"));
        }

        [Fact]
        public void FormatWith()
        {
            Assert.Equal("1: a", "1: {0}".FormatWith("a"));
            Assert.Equal("2: a b", "2: {0} {1}".FormatWith("a", "b"));
        }
    }
}
