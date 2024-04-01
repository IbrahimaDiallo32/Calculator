using Calculator_App;

namespace CalculatorTestProject1;

public class CalculatorTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void AddTwoNumbers()
    {
        var calculator = new CalculatorEngine(); // Assuming AddTwoNumbers is a method of the Calculator class
        float number1 = 2.5f;
        float number2 = 3.5f;
        float expectedSum = 6.0f;

        // Act
        float result = calculator.AddTwoNumbers(number1, number2);

        // Assert
        Assert.AreEqual(expectedSum, result, 0.001, "The sum of the two numbers does not match the expected value.");
    
    }
}
