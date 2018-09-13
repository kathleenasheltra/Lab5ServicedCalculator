using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCalculations
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddTest()
        {
            var calcRef = new Calculator.CalculatorSoapClient();
            var sum = calcRef.Add(1, 1);
            Assert.AreEqual(2, sum);
        }
        [TestMethod]
        public void SubtractTest()
        {
            var calcRef = new Calculator.CalculatorSoapClient();
            var difference = calcRef.Subtract(1, 1);
            Assert.AreEqual(0, difference);
        }
        [TestMethod]
        public void MultiplyTest()
        {
            var calcRef = new Calculator.CalculatorSoapClient();
            var product = calcRef.Multiply(9, 2);
            Assert.AreEqual(18, product);
        }
        [TestMethod]
        public void DivideTest()
        {
            var calcRef = new Calculator.CalculatorSoapClient();
            var quotient = calcRef.Divide(1, 1);
            Assert.AreEqual(1, quotient);
        }
        [TestMethod]
        public void SqrRootTest()
        {
            var calcRef = new Calculator.CalculatorSoapClient();
            var root = calcRef.SqrRoot(9);
            Assert.AreEqual(3, root);
        }
        [TestMethod]
        public void HalveTest()
        {
            var calcRef = new Calculator.CalculatorSoapClient();
            var halve = calcRef.Halve(20);
            Assert.AreEqual(10, halve);
        }
        [TestMethod]
        public void QuarterTest()
        {
            var calcRef = new Calculator.CalculatorSoapClient();
            var quarter = calcRef.Quarter(20);
            Assert.AreEqual(5, quarter);
        }
    }
}
