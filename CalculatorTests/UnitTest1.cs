using System.Xml.XPath;

namespace CalculatorTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestAdd()
        {
            double result = Calculator.MainWindow.Add(2, 3);
            Assert.Equal(5, result);
        }

        [Fact]
        public void AddWithNegative()
        {
            double result = Calculator.MainWindow.Add(5, -10);
            Assert.Equal(-5, result);
        }

        [Fact]
        public void TestSubtract()
        {
            double result = Calculator.MainWindow.Minus(7, 2);
            Assert.Equal(5, result);
        }

        [Fact]
        public void SubtractWithNegative()
        {
            double result = Calculator.MainWindow.Minus(5, -10);
            Assert.Equal(15, result);
        }

        [Fact]
        public void TestDivide()
        {
            double result = Calculator.MainWindow.Divide(10, 2);
            Assert.Equal(5, result);
        }

        [Fact]
        public void DivideWithNegative()
        {
            double result = Calculator.MainWindow.Divide(5, -10);
            Assert.Equal(-.5, result);
        }

        [Fact]
        public void TestMultiply()
        {
            double result = Calculator.MainWindow.Multiple(2, 5);
            Assert.Equal(10, result);
        }

        [Fact]
        public void MultiplyWithNegative()
        {
            double result = Calculator.MainWindow.Multiple(5, -10);
            Assert.Equal(-50, result);
        }
    }
}