using CalculatorEngine;

namespace CalculatorTestProject1;

//Unit Tests for Addition() Function
public class AdditionUnitTest
{
   
    [Test]
    public void Addition_TwoPositiveDoubles_ReturnsPositiveSum()
    {
        //preq-UNIT-TEST-2
        
        //Arrange
        double number1 = 2.5;
        double number2 = 3.5;
        double expectedSum = 6.0;

        // Act
        var result = CalculatorLogic.AddTwoNumbers(number1, number2);

        // Assert
        Assert.That(expectedSum, Is.EqualTo(result), "The sum of the two numbers does not match the expected value.");
    
    }
    [Test]
    public void Addition_TwoNegativeDoubles_ReturnsNegativeSum()
    {
        
        //Arrange
        double number1 = -3.25;
        double number2 = -1.75;
        double expectedSum = -5.0;

        // Act
        var result = CalculatorLogic.AddTwoNumbers(number1, number2);

        // Assert
        Assert.That(expectedSum, Is.EqualTo(result), "The sum of the two numbers does not match the expected value.");
    
    }
}