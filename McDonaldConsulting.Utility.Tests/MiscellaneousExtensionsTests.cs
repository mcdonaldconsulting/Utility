namespace McDonaldConsulting.Utility.Tests
{
    using System;
    using Xunit;

    public class MiscellaneousExtensionsTests
    {
        public class IsBetweenMethodForInt32
        {
            private const int Below = 1;
            private const int Lower = 2;
            private const int Inside = 3;
            private const int Upper = 4;
            private const int Above = 5;

            [Fact]
            public void IsBetweenBelowReturnsFalse()
            {
                Assert.False(Below.IsBetween(Lower, Upper));
            }

            [Fact]
            public void IsBetweenLowerBoundReturnsTrue()
            {
                Assert.True(Lower.IsBetween(Lower, Upper));
            }

            [Fact]
            public void IsBetweenInsideReturnsTrue()
            {
                Assert.True(Inside.IsBetween(Lower, Upper));
            }

            [Fact]
            public void IsBetweenUpperBoundReturnsTrue()
            {
                Assert.True(Upper.IsBetween(Lower, Upper));
            }

            [Fact]
            public void IsBetweenAboveReturnsFalse()
            {
                Assert.False(Above.IsBetween(Lower, Upper));
            }
        }

        public class IsBetweenMethodForDecimal
        {
            private const decimal Below = 0.999999m;
            private const decimal Lower = 1.0m;
            private const decimal Inside = 1.5m;
            private const decimal Upper = 2.0m;
            private const decimal Above = 2.000001m;

            [Fact]
            public void IsBetweenBelowReturnsFalse()
            {
                Assert.False(Below.IsBetween(Lower, Upper));
            }

            [Fact]
            public void IsBetweenLowerBoundReturnsTrue()
            {
                Assert.True(Lower.IsBetween(Lower, Upper));
            }

            [Fact]
            public void IsBetweenInsideReturnsTrue()
            {
                Assert.True(Inside.IsBetween(Lower, Upper));
            }

            [Fact]
            public void IsBetweenUpperBoundReturnsTrue()
            {
                Assert.True(Upper.IsBetween(Lower, Upper));
            }

            [Fact]
            public void IsBetweenAboveReturnsFalse()
            {
                Assert.False(Above.IsBetween(Lower, Upper));
            }
        }

        public class IsBetweenMethodForDateTime
        {
            private static readonly DateTime Lower = new DateTime(2010, 6, 30);
            private static readonly DateTime Upper = Lower.AddDays(1);
            private static readonly DateTime Below = Lower.AddTicks(-1);
            private static readonly DateTime Inside = Lower.AddHours(12);
            private static readonly DateTime Above = Upper.AddTicks(1);

            [Fact]
            public void IsBetweenBelowReturnsFalse()
            {
                Assert.False(Below.IsBetween(Lower, Upper));
            }

            [Fact]
            public void IsBetweenLowerBoundReturnsTrue()
            {
                Assert.True(Lower.IsBetween(Lower, Upper));
            }

            [Fact]
            public void IsBetweenInsideReturnsTrue()
            {
                Assert.True(Inside.IsBetween(Lower, Upper));
            }

            [Fact]
            public void IsBetweenUpperBoundReturnsTrue()
            {
                Assert.True(Upper.IsBetween(Lower, Upper));
            }

            [Fact]
            public void IsBetweenAboveReturnsFalse()
            {
                Assert.False(Above.IsBetween(Lower, Upper));
            }
        }
    }
}
