
using CalculatorEngine;

namespace CalculatorTestProject1;
//Unit Tests For Tan Function
//Do we need to include one for pi/2 where tan is undefined and 3pi/2
public class TanUnitTest
{
    //preq-UNIT-TEST-18
    [Test]
    public void TanOfDouble_Zero_ReturnsZero()
    {
        //Arrange
        double value = 0;
        double expected = 0;
        //Act
        var result =CalculatorLogic.TanOfDouble(value);
        //Assert
        Assert.That(result, Is.EqualTo(expected).Within(0.0001), "Tangent of 0 should be 0.");
    }
    [Test]
    public void TanOfDouble_TwoPi_ReturnsZero()
    {   
        //Arrange
        double value = 2 * (double)Math.PI;
        double expected = 0;
        //Act
        var result = CalculatorLogic.TanOfDouble(value);
        //Assert
        Assert.That(result, Is.EqualTo(expected).Within(0.0001), "Tangent of 2π should be 0.");
    }
    [Test]
    public void TanOfDouble_NegativeTwoPi_ReturnsZero()
    {   
        //Arrange
        double value = -2 * (double)Math.PI;
        double expected = 0;
        //Act
        var result = CalculatorLogic.TanOfDouble(value);
        //Assert
        Assert.That(result, Is.EqualTo(expected).Within(0.0001), "Tangent of -2π should be 0.");
    }
}