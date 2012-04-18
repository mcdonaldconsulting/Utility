namespace McDonaldConsulting.Utility.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MiscellaneousExtensionsTests
    {
        [TestClass]
        public class IsBetweenMethodForInt32
        {
            private const int Below = 1;
            private const int Lower = 2;
            private const int Inside = 3;
            private const int Upper = 4;
            private const int Above = 5;

            [TestMethod]
            public void IsBetweenBelowReturnsFalse()
            {
                Assert.IsFalse(Below.IsBetween(Lower, Upper));
            }

            [TestMethod]
            public void IsBetweenLowerBoundReturnsTrue()
            {
                Assert.IsTrue(Lower.IsBetween(Lower, Upper));
            }

            [TestMethod]
            public void IsBetweenInsideReturnsTrue()
            {
                Assert.IsTrue(Inside.IsBetween(Lower, Upper));
            }

            [TestMethod]
            public void IsBetweenUpperBoundReturnsTrue()
            {
                Assert.IsTrue(Upper.IsBetween(Lower, Upper));
            }

            [TestMethod]
            public void IsBetweenAboveReturnsFalse()
            {
                Assert.IsFalse(Above.IsBetween(Lower, Upper));
            }
        }

        [TestClass]
        public class IsBetweenMethodForDecimal
        {
            private const decimal Below = 0.999999m;
            private const decimal Lower = 1.0m;
            private const decimal Inside = 1.5m;
            private const decimal Upper = 2.0m;
            private const decimal Above = 2.000001m;

            [TestMethod]
            public void IsBetweenBelowReturnsFalse()
            {
                Assert.IsFalse(Below.IsBetween(Lower, Upper));
            }

            [TestMethod]
            public void IsBetweenLowerBoundReturnsTrue()
            {
                Assert.IsTrue(Lower.IsBetween(Lower, Upper));
            }

            [TestMethod]
            public void IsBetweenInsideReturnsTrue()
            {
                Assert.IsTrue(Inside.IsBetween(Lower, Upper));
            }

            [TestMethod]
            public void IsBetweenUpperBoundReturnsTrue()
            {
                Assert.IsTrue(Upper.IsBetween(Lower, Upper));
            }

            [TestMethod]
            public void IsBetweenAboveReturnsFalse()
            {
                Assert.IsFalse(Above.IsBetween(Lower, Upper));
            }
        }

        [TestClass]
        public class IsBetweenMethodForDateTime
        {
            private static readonly DateTime Lower = new DateTime(2010, 6, 30);
            private static readonly DateTime Upper = Lower.AddDays(1);
            private static readonly DateTime Below = Lower.AddTicks(-1);
            private static readonly DateTime Inside = Lower.AddHours(12);
            private static readonly DateTime Above = Upper.AddTicks(1);

            [TestMethod]
            public void IsBetweenBelowReturnsFalse()
            {
                Assert.IsFalse(Below.IsBetween(Lower, Upper));
            }

            [TestMethod]
            public void IsBetweenLowerBoundReturnsTrue()
            {
                Assert.IsTrue(Lower.IsBetween(Lower, Upper));
            }

            [TestMethod]
            public void IsBetweenInsideReturnsTrue()
            {
                Assert.IsTrue(Inside.IsBetween(Lower, Upper));
            }

            [TestMethod]
            public void IsBetweenUpperBoundReturnsTrue()
            {
                Assert.IsTrue(Upper.IsBetween(Lower, Upper));
            }

            [TestMethod]
            public void IsBetweenAboveReturnsFalse()
            {
                Assert.IsFalse(Above.IsBetween(Lower, Upper));
            }
        }
    }
}
