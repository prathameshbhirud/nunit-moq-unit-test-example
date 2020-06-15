using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicMath;

namespace BasicMathTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_AddMethod()
        {
            BasicMaths bm = new BasicMaths();
            double res = bm.Add(10, 10);
            Assert.AreEqual(res, 20);
        }

        [TestMethod]
        public void Test_SubtractMethod()
        {
            BasicMaths bm = new BasicMaths();
            double res = bm.Substract(100, 50);
            Assert.AreEqual(res, 50);
        }

        [TestMethod]
        public void Test_MultiplyMethod()
        {
            BasicMaths bm = new BasicMaths();
            double res = bm.Multiply(10, 10);
            Assert.AreEqual(res, 100);
        }

        [TestMethod]
        public void Test_DivideMethod()
        {
            BasicMaths bm = new BasicMaths();
            double res = bm.divide(10, 2);
            Assert.AreEqual(res, 5);
        }
    }
}
