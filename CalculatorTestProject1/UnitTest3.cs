using Calculator_App.Components.Pages;

namespace CalculatorTestProject1;

public class UnitTest3
{
        private Calculator _calculator;

        public void TestInitialize()
        {
            // This method runs before each test to set up any required objects or state.
            _calculator = new Calculator();
        }

        public void MultiplyTwoFloatNumbers_BothPositive_ReturnsPositive()
        {
            // Arrange
            float num1 = 5f;
            float num2 = 10f;
            float expected = 50f;

            // Act
            float result = _calculator.MultiplyTwoFloatNumbers(num1, num2);

            // Assert
            Assert.AreEqual(expected, result, "Multiplying two positive numbers should return a positive result.");
        }

        
        public void MultiplyTwoFloatNumbers_OnePositiveOneNegative_ReturnsNegative()
        {
            // Arrange
            float num1 = -5f;
            float num2 = 10f;
            float expected = -50f;

            // Act
            float result = _calculator.MultiplyTwoFloatNumbers(num1, num2);

            // Assert
            Assert.AreEqual(expected, result, "Multiplying a positive number by a negative number should return a negative result.");
        }


        public void MultiplyTwoFloatNumbers_BothNegative_ReturnsPositive()
        {
            // Arrange
            float num1 = -5f;
            float num2 = -10f;
            float expected = 50f;

            // Act
            float result = _calculator.MultiplyTwoFloatNumbers(num1, num2);

            // Assert
            Assert.AreEqual(expected, result, "Multiplying two negative numbers should return a positive result.");
        }

        public void MultiplyTwoFloatNumbers_WithZero_ReturnsZero()
        {
            // Arrange
            float num1 = 0f;
            float num2 = 10f;
            float expected = 0f;

            // Act
            float result = _calculator.MultiplyTwoFloatNumbers(num1, num2);

            // Assert
            Assert.AreEqual(expected, result, "Multiplying any number by zero should return zero.");
        }
    }
