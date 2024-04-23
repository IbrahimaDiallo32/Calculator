using CalculatorEngine;

namespace CalculatorTestProject1;

//Unit Tests for Multiplication() Function
public class UnitTest3
{

    [Test]
    public void Multiply_TwoPositiveDoubles_ReturnsPositive()
    {
        //preq-UNIT-TEST-5
        
        // Arrange
        double num1 = 5;
        double num2 = 10;
        double expected = 50;

        // Act
        double result = CalculatorLogic.MultiplyTwoNumbers(num1, num2);

        // Assert
        Assert.That(expected, Is.EqualTo(result), "Multiplying two positive numbers should return a positive result.");
    }
    [Test]
    public void Multiply_OnePositiveDoubleOneNegativeDouble_ReturnsNegative()
    {
        // Arrange
        double num1 = -5;
        double num2 = 10;
        double expected = -50;

        // Act
        double result = CalculatorLogic.MultiplyTwoNumbers(num1, num2);

        // Assert
        Assert.That(expected, Is.EqualTo(result), "Multiplying a positive number by a negative number should return a negative result.");
    }

    [Test]
    public void Multiply_TwoNegativeDoubles_ReturnsPositive()
    {
        // Arrange
        double num1 = -5;
        double num2 = -10;
        double expected = 50;

        // Act
        double result = CalculatorLogic.MultiplyTwoNumbers(num1, num2);

        // Assert
        Assert.That(expected, Is.EqualTo(result), "Multiplying two negative numbers should return a positive result.");
    }

    [Test]
    public void Multiply_OneDoubleIsZero_ReturnsZero()
    {
        // Arrange
        double num1 = 0;
        double num2 = 10;
        double expected = 0;

        // Act
        double result = CalculatorLogic.MultiplyTwoNumbers(num1, num2);

        // Assert
        Assert.That(expected, Is.EqualTo(result), "Multiplying any number by zero should return zero.");
    }

}
