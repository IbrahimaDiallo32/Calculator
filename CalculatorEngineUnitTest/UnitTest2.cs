using Calculator_App;

namespace CalculatorTestProject1;

//Unit Tests for Subtraction() Functions
public class UnitTest2
{
    [Test]
    public void Subtraction_TwoFloatingPointValues_ReturnsDifference()
    {
        //preq-UNIT-TEST-3
        
        // Arrange
        var calculator = new CalculatorEngine(); 
        float number1 = 5.5f;
        float number2 = 3.0f;
        float expectedDifference = 2.5f;

        // Act
        float result = calculator.SubtractTwoNumber(number1, number2);

        // Assert
        Assert.That(expectedDifference, Is.EqualTo(result),  "The difference between the two numbers does not match the expected value.");
    }
} 