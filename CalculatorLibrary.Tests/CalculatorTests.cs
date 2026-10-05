using CalculatorLibrary;
using NUnit.Framework;

namespace CalculatorLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Add_ReturnsEight_WhenGivenFiveAndThree()
        {
            // Arrange
            Calculator calculator = new Calculator();
            int expectedResult = 8;

            // Act
            int actualResult = calculator.Add(5, 3);

            // Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Subtract_ReturnsSix_WhenGivenTenAndFour()
        {
            // Arrange
            Calculator calculator = new Calculator();
            int expectedResult = 6;

            // Act
            int actualResult = calculator.Subtract(10, 4);

            // Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Add_ReturnsNegativeOne_WhenGivenNegativeFiveAndFour()
        {
            // Arrange
            Calculator calculator = new Calculator();
            int expectedResult = -1;
            // Act
            int actualResult = calculator.Add(-5, 4);
            // Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
    }
}