using CalculatorEngine;

namespace CalculatorTestProject1;

//Unit Tests for Addition() Function
public class UnitTest1
{
   
    [Test]
    public void Addition_TwoDoubles_ReturnsSum()
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
}