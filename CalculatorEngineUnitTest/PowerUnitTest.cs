using CalculatorEngine;

namespace CalculatorTestProject1;
//Unit Test for Power Function
public class PowerUnitTest

{
    [Test]
        public void PowerFunction_WithPositiveNumbers_ReturnsCorrectResult()
        {
            // preq-UNIT-TEST-8
            // Arrange
            double baseNumber = 2;
            double exponent = 3;
            double expected =8;

            // Act
            double result = CalculatorLogic.PowerFunction(baseNumber, exponent);

            // Assert
            Assert.That(expected, Is.EqualTo(result), "The power function calculates correctly with positive numbers.");
        }

        [Test]
        public void PowerFunction_WithZeroBaseAndPositiveExponent_ReturnsZero()
        {
            // Arrange
            double baseNumber = 0;
            double exponent = 3;
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
            double baseNumber = -2;
            double exponent = 3; // Note: Exponent is an integer value.
            double expected = 8;

            // Act
            var result = CalculatorLogic.PowerFunction(baseNumber, exponent);

            // Assert
            Assert.That(expected, Is.EqualTo(result),  "The power function does not handle negative bases with an integer exponent correctly.");
        }

        [Test]
        public void PowerFunction_WithOneAsExponent_ReturnsBase()
        {
            // Arrange
            double baseNumber = 5;
            double exponent = 1;
            double expected = 5;

            // Act
            var result = CalculatorLogic.PowerFunction(baseNumber, exponent);

            // Assert
            Assert.That(expected, Is.EqualTo(result), "The power function does not return the base when the exponent is 1.");
        }
}
