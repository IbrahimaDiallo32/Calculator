
using CalculatorEngine;

namespace CalculatorTestProject1;

//Do we need to include one for pi/2 where tan is undefined and 3pi/2
public class UnitTest10
{
    //preq-UNIT-TEST-15
    [Test]
    public void TanOfDouble_Zero_ReturnsZero()
    {
        //Arrange
        double expected = 0;
        //Act
        var result =CalculatorLogic.TanOfDouble(0);
        //Assert
        Assert.That(result, Is.EqualTo(expected).Within(0.0001), "Tangent of 0 should be 0.");
    }

    [Test]
    public void TanOfDouble_Pi_ReturnsZero()
    {   
        //Arrange
        double expected = 0;
        //Act
        var result =CalculatorLogic.TanOfDouble((double)Math.PI);
        //Assert
        Assert.That(result, Is.EqualTo(expected).Within(0.0001), "Tangent of π should be approximately 0.");
    }

    [Test]
    public void TanOfDouble_PiOverFour_ReturnsOne()
    {   
        //Arrange
        double expected = 1;
        //Act
        var result = CalculatorLogic.TanOfDouble((double)Math.PI / 4);
        //Assert
        Assert.That(result, Is.EqualTo(expected).Within(0.0001), "Tangent of π/4 should be 1.");
    }

    
    [Test]
    public void TanOfDouble_NearPiOverTwo_ReturnsVeryLargeValue()
    {   
        //Arrange
        double expected = 0;
        //Act
        var result = CalculatorLogic.TanOfDouble((double)Math.PI / 2 - 0.01f);
        //Assert
        Assert.That(result > 100,Is.EqualTo(false),"Tangent near π/2 should be very large.");
    }

    [Test]
    public void TanOfDouble_ThreePiOverTwo_ReturnsVeryLargeValue()
    {   
        //Arrange
        double expected = 0;
        //Act
        var result = CalculatorLogic.TanOfDouble(3 * (double)Math.PI / 2 - 0.01f);
        //Assert
        Assert.That(result < -100,Is.EqualTo(false), "Tangent near 3π/2 should be very large and negative.");
    }

    [Test]
    public void TanOfDouble_TwoPi_ReturnsZero()
    {   
        //Arrange
        double expected = 0;
        //Act
        var result = CalculatorLogic.TanOfDouble(2 * (double)Math.PI);
        //Assert
        Assert.That(result, Is.EqualTo(expected).Within(0.0001), "Tangent of 2π should be 0.");
    }
}