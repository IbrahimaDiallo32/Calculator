using CalculatorEngine;

namespace CalculatorTestProject1;
//Unit Tests For Sin Function//
public class SinUnitTest
{   
    [Test]
    public void SinOfDoubles_Zero_ReturnsZero()
    {
        //Arrange
        double value = 0;
        double expected = 0;
        //Act
        var result = CalculatorLogic.SinOfDouble(value);
        //Assert
        Assert.That(expected,Is.EqualTo(result),"Sine of 0 should 0");
    }

    [Test]
    public void SinOfDoubles_PositiveNumber_ReturnsZero()
    {
        //Arrange
        double value = 360;
        double expected = 0;
        //Act
        var result = CalculatorLogic.SinOfDouble(value);
        //Assert
        Assert.That(expected,Is.EqualTo(result).Within(00001),"Sine of 360 should 0");
    }
    [Test]
    public void SinOfDoubles_Number1_ReturnsZero()
    {
        //Arrange
        double value = 1;
        double expected = 0.0174524;
        //Act
        var result = CalculatorLogic.SinOfDouble(value);
        //Assert
        Assert.That(expected,Is.EqualTo(result).Within(00001),"Sine of 1 should 0.0174524");
    }

}