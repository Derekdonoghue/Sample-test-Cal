using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests.Unit
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void AddTwoNumbers()
        {
            double result = Calculator.Calculate(1, 2, "+");
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void SubtractTwoNumbers()
        {
            double result = Calculator.Calculate(3, 2, "-");
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void MultiplyTwoNumbers()
        {
            double result = Calculator.Calculate(1, 2, "*");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void DivideTwoNumbers()
        {
            double result = Calculator.Calculate(4, 2, "/");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Squarednumber()
        {
            double result = Calculator.Calculate(10, 10, "s");
            Assert.AreEqual(100, result);

        }


        [TestMethod]
        public void Squareroot()
        {
            double result = Calculator.Calculate(100, 10, "r");
            Assert.AreEqual(10, result);

        }

        [TestMethod]
        public void CosNumber()
        {
            double result = Calculator.Calculate(10, 0, "c");
            Assert.AreEqual(-1, result);

        }

        [TestMethod]
        public void TanNumber()
        {
            double result = Calculator.Calculate(10, 0, "t");
            Assert.AreEqual(1, result);

        }

        [TestMethod]
        public void SinNumber()
        {
            double result = Calculator.Calculate(10, 0, "i");
            Assert.AreEqual(-1, result);

        }

        [TestMethod]
        public void RemainderNumber()
        {
            double result = Calculator.Calculate(10, 10, "%");
            Assert.AreEqual(0, result);

        }




        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void ConfirmInvalidSymbolicOperationsAreNotSupported_Completely()
        {
            double result = Calculator.Calculate(5, 10, "&");
        }



    }
}
