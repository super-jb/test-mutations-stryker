using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculator.Library.UnitTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        [DataRow(5, 5, 10)]
        public void TestAdd(int a, int b, long expected)
        {
            var result = Calculator.Add(a, b);

            result.Should().Be(expected);
        }

        [TestMethod]
        [DataRow(5, 5, 0)]
        [DataRow(6, 4, 2)]
        public void TestSubrtact(int a, int b, int expected)
        {
            var result = Calculator.Subtract(a, b);

            result.Should().Be(expected);
        }

        [TestMethod]
        [DataRow(1, 1, 1)]
        [DataRow(2, 4, 8)]
        public void TestMultiply(int a, int b, long expected)
        {
            var result = Calculator.Multiply(a, b);

            result.Should().Be(expected);
        }

        [TestMethod]
        [DataRow(1, 1, 1, 0)]
        [DataRow(4, 2, 2, 0)]
        [DataRow(5, 2, 2, 1)]
        public void TestDivide(int a, int b, int expected, int remainder)
        {
            var result = Calculator.Divide(a, b);

            result.Result.Should().Be(expected);
            result.Remainder.Should().Be(remainder);
        }

        [TestMethod]
        public void TestDivideByZero()
        {
            Action result = () => Calculator.Divide(10, 0);

            result
                .Should().Throw<DivideByZeroException>()
                .And.Message
                .Should().Be("Go back to school!");
        }
    }
}