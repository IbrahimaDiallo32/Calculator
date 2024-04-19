
using CalculatorEngine;

namespace CalculatorTestProject1;

public class UnitTest10
{
    [Test]
    public void TanOfFloat_Zero_ReturnsZero()
    {
        //Arrange
        double expected = 0;
        //Act
        var result =CalculatorLogic.TanOfDouble(0);
        //Assert
        Assert.That(result, Is.EqualTo(expected).Within(0.0001), "Tangent of 0 should be 0.");
    }

    [Test]
    public void TanOfFloat_Pi_ReturnsZero()
    {   
        //Arrange
        double expected = 0;
        //Act
        var result =CalculatorLogic.TanOfDouble((float)Math.PI);
        //Assert
        Assert.That(result, Is.EqualTo(expected).Within(0.0001), "Tangent of π should be approximately 0.");
    }

    [Test]
    public void TanOfFloat_PiOverFour_ReturnsOne()
    {   
        //Arrange
        double expected = 1;
        //Act
        var result = CalculatorLogic.TanOfDouble((float)Math.PI / 4);
        //Assert
        Assert.That(result, Is.EqualTo(expected).Within(0.0001), "Tangent of π/4 should be 1.");
    }

    
    [Test]
    public void TanOfFloat_NearPiOverTwo_ReturnsVeryLargeValue()
    {   
        //Arrange
        double expected = 0;
        //Act
        var result = CalculatorLogic.TanOfDouble((float)Math.PI / 2 - 0.01f);
        //Assert
        Assert.That(result > 100,Is.EqualTo(false),"Tangent near π/2 should be very large.");
    }

    [Test]
    public void TanOfFloat_ThreePiOverTwo_ReturnsVeryLargeValue()
    {   
        //Arrange
        double expected = 0;
        //Act
        var result = CalculatorLogic.TanOfDouble(3 * (float)Math.PI / 2 - 0.01f);
        //Assert
        Assert.That(result < -100,Is.EqualTo(false), "Tangent near 3π/2 should be very large and negative.");
    }

    [Test]
    public void TanOfFloat_TwoPi_ReturnsZero()
    {   
        //Arrange
        double expected = 0;
        //Act
        var result = CalculatorLogic.TanOfDouble(2 * (float)Math.PI);
        //Assert
        Assert.That(result, Is.EqualTo(expected).Within(0.0001), "Tangent of 2π should be 0.");
    }
}