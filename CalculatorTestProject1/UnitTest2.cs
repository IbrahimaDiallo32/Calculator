using Calculator_App.Components.Pages;

namespace CalculatorTestProject1;

public class UnitTest2
{
    public void SubtractTwoNumbers()
    {
        // Arrange
        var calculator = new Calculator(); 
        float number1 = 5.5f;
        float number2 = 3.0f;
        float expectedDifference = 2.5f;

        // Act
        float result = calculator.SubtractTwoNumber(number1, number2);

        // Assert
        Assert.AreEqual(expectedDifference, result, 0.001, "The difference between the two numbers does not match the expected value.");
    }
}