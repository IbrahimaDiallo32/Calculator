
using CalculatorEngine;

namespace CalculatorTestProject1;
// Unit Tests for Inverse Functions 
//We may need to include one for division by 0
public class InverseUnitTest
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
        double testValue = -4;
        double expected = -0.25;
        //Act
        var result = CalculatorLogic.InverseOfDouble(testValue);
        //Assert
        Assert.That(result, Is.EqualTo(expected).Within(0.0001), $"Inverse of {testValue} should be -0.25.");
    }
    [Test]

    public void InverseOfDouble_Zero_ReturnsError()
    {   
        //Arrange
        double testValue = 0;
       
        //Act
        var result = CalculatorLogic.InverseOfDouble(testValue);
        //Assert
        Assert.That(result, Is.NaN, $"Inverse of Zero should be Error.");
    }


}