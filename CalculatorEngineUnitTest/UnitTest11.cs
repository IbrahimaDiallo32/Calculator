
using CalculatorEngine;

namespace CalculatorTestProject1;

public class UnitTest11
{
    [Test]
    public void InverseOfDouble_PositiveNumber_ReturnsInverse()
    {   
        //Arrange 
        double testValue = 2;
        double expected = 0.5;
        
        //Act
        var result = CalculatorLogic.InverseOfDouble(testValue);
        
        //Assert
        Assert.That(result, Is.EqualTo(expected).Within(0.0001), $"Inverse of {testValue} should be 0.5.");
    }

    [Test]
    public void InverseOfDouble_NegativeNumber_ReturnsInverse()
    {   
        //Arrange
        double expected = -0.5;
        double testValue = -2;
        //Act
        var result = CalculatorLogic.InverseOfDouble(testValue);
        //Assert
        Assert.That(result, Is.EqualTo(expected).Within(0.0001), $"Inverse of {testValue} should be -0.5.");
    }

    [Test]
    public void InverseOfDouble_VerySmallNumber_ReturnsLargeInverse()
    {
        //Arrange
        double expected = 10000;
        double testValue = 0.0001; 
        //Act
        var result = CalculatorLogic.InverseOfDouble(testValue);
        //Assert
        Assert.That(result, Is.EqualTo(expected).Within(1), $"Inverse of {testValue} should be approximately 10000.");
    }
}