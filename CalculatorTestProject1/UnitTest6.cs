using Calculator_App;

namespace CalculatorTestProject1;

public class UnitTest6
{
    [Test]
        public void PowerFunction_WithPositiveNumbers_ReturnsCorrectResult()
        {
            // Arrange
            var calculator = new CalculatorEngine();
            float baseNumber = 2f;
            float exponent = 3f;
            double expected = Math.Pow(2, 3);

            // Act
            var result = CalculatorEngine.PowerFunction(baseNumber, exponent);

            // Assert
            Assert.AreEqual(expected, result, 0.0001, "The power function does not calculate correctly with positive numbers.");
        }

        [Test]
        public void PowerFunction_WithZeroBaseAndPositiveExponent_ReturnsZero()
        {
            // Arrange
            var calculator = new CalculatorEngine();
            float baseNumber = 0f;
            float exponent = 3f;
            double expected = 0;

            // Act
            var result = CalculatorEngine.PowerFunction(baseNumber, exponent);

            // Assert
            Assert.AreEqual(expected, result, "The power function does not return zero when the base is zero and the exponent is positive.");
        }

        [Test]
        public void PowerFunction_WithNegativeBaseAndIntegerExponent_ReturnsCorrectResult()
        {
            // Arrange
            var calculator = new CalculatorEngine();
            float baseNumber = -2f;
            float exponent = 3f; // Note: Exponent is an integer value.
            double expected = -8;

            // Act
            var result = CalculatorEngine.PowerFunction(baseNumber, exponent);

            // Assert
            Assert.AreEqual(expected, result, 0.0001, "The power function does not handle negative bases with an integer exponent correctly.");
        }

        [Test]
        public void PowerFunction_WithOneAsExponent_ReturnsBase()
        {
            // Arrange
            var calculator = new CalculatorEngine();
            float baseNumber = 5f;
            float exponent = 1f;
            double expected = 5;

            // Act
            var result = CalculatorEngine.PowerFunction(baseNumber, exponent);

            // Assert
            Assert.AreEqual(expected, result, "The power function does not return the base when the exponent is 1.");
        }
}