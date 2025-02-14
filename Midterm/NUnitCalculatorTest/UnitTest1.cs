using static Midterm.Calculator;
using NUnit.Framework;
using Midterm;

namespace NUnitCalculatorTest
{
    public class UnitTest1
    {
        private Calculator _calculator { get; set; } = null;


        [TestCase(-10, "The number is negative.")]
        [TestCase(0, "The number is zero.")]
        [TestCase(10, "The number is between 1 and 10.")]
        [TestCase(20, "The number is between 11 and 20.")]
        [TestCase(30, "The number is between 21 and 30.")]
        public void CategorizeNumber_Test(int number, string sentence)
        {
            // Act
            string result = Calculator.CategorizeNumber(number);

            // Assert
            Assert.AreEqual(sentence, result);
        }
    }
}