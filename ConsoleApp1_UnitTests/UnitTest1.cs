using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleApp1_UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForCalculateExp_WhenBothArgumentsArePositive()
        {
            var e = new TaylorSeries();
            var actual = e.CalculateExp(4, 3);
            var expected = 13 + 64.0 / 6 ;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestForCalculateExp_WhenfirstArgumentIsZero()
        {
            var e = new TaylorSeries();
            var actual = e.CalculateExp(0, 3);
            var expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestForCalculateExp_WhenfirstArgumentIsNegative()
        {
            var e = new TaylorSeries();
            var actual = e.CalculateExp(-2, 4);
            var expected = 1 - 2.0 / 3;

            Assert.AreEqual(expected, actual);
        }
    }
}
