using CalculatorEngine;

namespace CalculatorTestProject1;
//Unit Tests For Sin Function//
public class UnitTest8
{   
    //preq-UNIT-TEST-16
    [Test]
    public void SinOfDoubles_Zero_ReturnsZero()
    {
        //Arrange
        double expected = 0;
        //Act
        var result = CalculatorLogic.SinOfDouble(0);
        //Assert
        Assert.That(expected,Is.EqualTo(result),"Sine of 0 should 0");
    }

    [Test]
    //preq-UNIT-TEST-16
    public void SinOfDoubles_PositiveNumber_ReturnsZero()
    {
        //Arrange
        double expected = 0;
        //Act
        var result = CalculatorLogic.SinOfDouble(360);
        //Assert
        Assert.That(expected,Is.EqualTo(result).Within(00001),"Sine of 0 should 0");
    }
    /*
    [Test]
    public void SinOfDoubles_PiOverTwo_ReturnsOne()
    {   
        //Arrange
        double expected = 1;
        var actual = Math.Sin(Math.PI/2);
        //Act
        var result = CalculatorLogic.SinOfDouble(Math.PI / 2);
        //Assert
        Assert.That(result, Is.EqualTo(expected).Within(0.0001), "Sine of π/2 should be 1.");
    }

    [Test]
    public void SinOfDoubles_Pi_ReturnsZero()
    {   
        //Arrange
        double expected = 0;
        //Act
        var result = CalculatorLogic.SinOfDouble((double)Math.PI);
        //Assert
        Assert.That(result, Is.EqualTo(expected).Within(0.0001),  "Sine of π should be 0.");
    }

    [Test]
    public void SinOfDoubles_ThreePiOverTwo_ReturnsMinusOne()
    {   
        //Arrange
        double expected = -1;
        //Act
        var result = CalculatorLogic.SinOfDouble(3 * (float)Math.PI / 2);
        //Assert
        Assert.That(result, Is.EqualTo(expected).Within(0.0001),  "Sine of 3π/2 should be -1.");
    }

    [Test]
    public void SinOfDoubles_TwoPi_ReturnsZero()
    {   
        //Arrange
        double expected = 0;
        //Act   
        var result = CalculatorLogic.SinOfDouble(2 * (float)Math.PI);
        //Assert
        Assert.That(result, Is.EqualTo(expected).Within(0.0001),  "Sine of 2π should be 0.");
    }

    [Test]
    public void SinOfDoubles_NegativeInput_ReturnsCorrectValue()
    {   
        //Arrange
        double expected = -1;
        //Act
        var result = CalculatorLogic.SinOfDouble(-(float)Math.PI / 2);
        //Assert
        Assert.That(result, Is.EqualTo(expected).Within(0.001), "Sine of -π/2 should be -1.");
    }*/
}