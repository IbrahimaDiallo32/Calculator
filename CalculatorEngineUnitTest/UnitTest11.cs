/*using Calculator_App;
namespace CalculatorTestProject1;

public class UnitTest11
{
    [Test]
    public void InverseOfFloat_PositiveNumber_ReturnsInverse()
    {   
        //Arrange 
        var calculator = new CalculatorEngine();
        float testValue = 2f;
        
        //Act
        var result = calculator.InverseOfFloat(testValue);
        
        //Assert
        Assert.That(result, Is.EqualTo(0.5).Within(0.0001), $"Inverse of {testValue} should be 0.5.");
    }

    [Test]
    public void InverseOfFloat_NegativeNumber_ReturnsInverse()
    {   
        //Arrange
        var calculator = new CalculatorEngine();
        float testValue = -2f;
        //Act
        var result = calculator.InverseOfFloat(testValue);
        //Assert
        Assert.That(result, Is.EqualTo(-0.5).Within(0.0001), $"Inverse of {testValue} should be -0.5.");
    }

    [Test]
    public void InverseOfFloat_VerySmallNumber_ReturnsLargeInverse()
    {
        //Arrange
        var calculator = new CalculatorEngine();
        float testValue = 0.0001f; 
        //Act
        var result = calculator.InverseOfFloat(testValue);
        //Assert
        Assert.That(result, Is.EqualTo(10000).Within(1), $"Inverse of {testValue} should be approximately 10000.");
    }
}*/