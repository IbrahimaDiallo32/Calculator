using CalculatorEngine;
namespace CalculatorTestProject1;
//Unit Tests For Cos Function
public class CosUnitTest
{
    //preq-UNIT-TEST-17
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
    public void CosOfDouble_PiOverTwo_ReturnsZero()
    {   
        //Arrange
        double expected = 0;
        //Act
        var result = CalculatorLogic.CosOfDouble((float)Math.PI / 2);
        //Assert
        Assert.That(result, Is.EqualTo(expected).Within(0.0001), "Cosine of π/2 should be 0.");
    }

    [Test]
    public void CosOfDouble_Pi_ReturnsMinusOne()
    {   
        //Arrange   
        double expected = -1;
        //Act
        var result = CalculatorLogic.CosOfDouble((float)Math.PI);
        //Assert
        Assert.That(result, Is.EqualTo(expected).Within(0.0001), "Cosine of π should be -1.");
    }

    [Test]
    public void CosOfDouble_ThreePiOverTwo_ReturnsZero()
    {   
        //Arrange   
        double expected = 0;
        //Act
        var result = CalculatorLogic.CosOfDouble(3 * (float)Math.PI / 2);
        //Assert
        Assert.That(result, Is.EqualTo(expected).Within(0.0001), "Cosine of 3π/2 should be 0.");
    }

    [Test]
    public void CosOfDouble_TwoPi_ReturnsOne()
    {   
        //Arrange   
        double expected = 1;
        //Act
        var result = CalculatorLogic.CosOfDouble(2 * (float)Math.PI);
        //Assert
        Assert.That(result, Is.EqualTo(expected).Within(0.0001), "Cosine of 2π should be 1.");
    }

    [Test]
    public void CosOfDouble_NegativeInput_ReturnsCorrectValue()
    {   
        //Arrange
        var expected = 0;
        //Act   
        var result = CalculatorLogic.CosOfDouble(-(float)Math.PI / 2);
        //Assert
        Assert.That(result, Is.EqualTo(expected).Within(0.0001), "Cosine of -π/2 should be 0.");
    }
    
}