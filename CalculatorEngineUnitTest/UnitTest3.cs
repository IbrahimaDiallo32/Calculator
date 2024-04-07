using Calculator_App;

namespace CalculatorTestProject1;

//Unit Tests for Multiplication() Function
public class UnitTest3
{

    [Test]
    public void Multiply_TwoPositiveFloatingPointValues_ReturnsPositive()
    {
        //preq-UNIT-TEST-4
        
        // Arrange
        var calculator = new CalculatorEngine();
        float num1 = 5f;
        float num2 = 10f;
        float expected = 50f;

        // Act
        float result = calculator.MultiplyTwoFloatNumbers(num1, num2);

        // Assert
        Assert.That(expected, Is.EqualTo(result), "Multiplying two positive numbers should return a positive result.");
    }
    [Test]
    public void Multiply_OnePositiveFloatOneNegativeFloat_ReturnsNegative()
    {
        // Arrange
        var calculator = new CalculatorEngine();
        float num1 = -5f;
        float num2 = 10f;
        float expected = -50f;

        // Act
        float result = calculator.MultiplyTwoFloatNumbers(num1, num2);

        // Assert
        Assert.That(expected, Is.EqualTo(result), "Multiplying a positive number by a negative number should return a negative result.");
    }

    [Test]
    public void Multiply_TwoNegativeFloatingPointValues_ReturnsPositive()
    {
        // Arrange
        var calculator = new CalculatorEngine();
        float num1 = -5f;
        float num2 = -10f;
        float expected = 50f;

        // Act
        float result = calculator.MultiplyTwoFloatNumbers(num1, num2);

        // Assert
        Assert.That(expected, Is.EqualTo(result), "Multiplying two negative numbers should return a positive result.");
    }

    [Test]
    public void Multiply_OneFloatIsZero_ReturnsZero()
    {
        // Arrange
        var calculator = new CalculatorEngine();
        float num1 = 0f;
        float num2 = 10f;
        float expected = 0f;

        // Act
        float result = calculator.MultiplyTwoFloatNumbers(num1, num2);

        // Assert
        Assert.That(expected, Is.EqualTo(result), "Multiplying any number by zero should return zero.");
    }

}
