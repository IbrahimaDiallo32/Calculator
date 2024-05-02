using CalculatorEngine;
namespace CalculatorTestProject1;
//Unit Tests For Cos Function
public class CosUnitTest
{
    [Test]
    public void CosOfDouble_Zero_ReturnsOne()
    {   
        //Arrange
        double expected = 1;
        //Act
        var result = CalculatorLogic.CosOfDouble(0f);
        //Assert
        Assert.That(result,Is.EqualTo(expected).Within(0.0001),"Cosine of 0 should be 1.");
    }
    
    [Test]
    public void CosOfDouble_TwoPi_ReturnsOne()
    {   
        //Arrange   
        double expected = 1;
        //Act
        var result = CalculatorLogic.CosOfDouble(2 * (float)Math.PI);
        //Assert
        Assert.That(result, Is.EqualTo(expected).Within(0.0001), "Cosine of 2π(360) should be 1.");
    }
    [Test]
    public void CosOfDouble_NegativeTwoPi_ReturnsOne()
    {   
        //Arrange 
        double value = 2 * (float)Math.PI;
        double expected = 1;
        //Act
        var result = CalculatorLogic.CosOfDouble(value);
        //Assert
        Assert.That(result, Is.EqualTo(expected).Within(0.0001), "Cosine of -2π should be 1.");
    }
}