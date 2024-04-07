using Calculator_App;

namespace CalculatorTestProject1;

//Unit Tests for Addition() Function
public class UnitTest1
{
   
    [Test]
    public void Addition_TwoFloatingPointValues_ReturnsSum()
    {
        //preq-UNIT-TEST-2
        
        //Arrange
        var calculator = new CalculatorEngine(); // Assuming AddTwoNumbers is a method of the Calculator class
        float number1 = 2.5f;
        float number2 = 3.5f;
        float expectedSum = 6.0f;

        // Act
        float result = calculator.AddTwoNumbers(number1, number2);

        // Assert
        Assert.That(expectedSum, Is.EqualTo(result), "The sum of the two numbers does not match the expected value.");
    
    }
}