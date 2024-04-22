using CalculatorEngine;

namespace CalculatorTestProject1;

public class UnitTest6
 // preq-UNIT-TEST-8
{
    [Test]
        public void PowerFunction_WithPositiveNumbers_ReturnsCorrectResult()
        {
            // Arrange
            double baseNumber = 2f;
            double exponent = 3f;
            double expected =8;

            // Act
            double result = CalculatorLogic.PowerFunction(baseNumber, exponent);

            // Assert
            Assert.That(expected, Is.EqualTo(result), "The power function does not calculate correctly with positive numbers.");
        }

        [Test]
        public void PowerFunction_WithZeroBaseAndPositiveExponent_ReturnsZero()
        {
            // Arrange
            double baseNumber = 0f;
            double exponent = 3f;
            double expected = 0;

            // Act
            double result = CalculatorLogic.PowerFunction(baseNumber, exponent);

            // Assert
            Assert.That(expected,Is.EqualTo(result), "The power function does not return zero when the base is zero and the exponent is positive.");
        }

        [Test]
        public void PowerFunction_WithNegativeBaseAndIntegerExponent_ReturnsCorrectResult()
        {
            // Arrange
            var calculator = new CalculatorLogic();
            double baseNumber = -2f;
            double exponent = 3f; // Note: Exponent is an integer value.
            double expected = -8;

            // Act
            var result = CalculatorLogic.PowerFunction(baseNumber, exponent);

            // Assert
            Assert.That(expected, Is.EqualTo(result),  "The power function does not handle negative bases with an integer exponent correctly.");
        }

        [Test]
        public void PowerFunction_WithOneAsExponent_ReturnsBase()
        {
            // Arrange
            double baseNumber = 5f;
            double exponent = 1f;
            double expected = 5;

            // Act
            var result = CalculatorLogic.PowerFunction(baseNumber, exponent);

            // Assert
            Assert.That(expected, Is.EqualTo(result), "The power function does not return the base when the exponent is 1.");
        }
}
