using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataDrivenTestDemo.Tests
{
    [TestClass]
    public class DataDrivenCalculatorTests
    {
        [DataTestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(2, 2, 4)]
        [DataRow(2, 3, 6)] // 故意写错，演示失败 subResult
        public void AddTest(int a, int b, int expected)
        {
            var result = Calculator.Add(a, b);
            Assert.AreEqual(expected, result, $"Adding {a} + {b}");
        }
    }

    public class Calculator
    {
        public static int Add(int x, int y) => x + y;
    }
}
