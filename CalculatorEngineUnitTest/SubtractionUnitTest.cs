using CalculatorEngine;

namespace CalculatorTestProject1;

//Unit Tests for Subtraction() Functions
public class SubtractionUnitTest
{
    [Test]
    public void Subtraction_TwoPositiveDoubles_ReturnsDifference()
    {
        // Arrange
        double number1 = 5.5;
        double number2 = 3.0;
        double expectedDifference = 2.5;

        // Act
        double result = CalculatorLogic.SubtractTwoNumbers(number1, number2);

        // Assert
        Assert.That(expectedDifference, Is.EqualTo(result),  "The difference between the two numbers does not match the expected value.");
    }
} 