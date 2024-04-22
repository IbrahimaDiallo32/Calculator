using CalculatorEngine;

namespace CalculatorTestProject1;

public class UnitTest7
{
    //preq-UNIT-TEST-14
    [Test]
    public void FactorialOfDouble_Zero_ReturnsOne()
    {   
        //Arrange
        double input = 0;
        double expected = 1;
        //Act
        var result = CalculatorLogic.FactorialOfDouble(input);
        //Assert
        Assert.That(expected, Is.EqualTo(result), "Factorial of 0 should return 1.");
    }

    [Test]
    public void FactorialOfDouble_One_ReturnsOne()
    {   
        //Arrange
        double input = 1;
        double expected = 1;
        //Act
        var result = CalculatorLogic.FactorialOfDouble(input);
        //Assert
        Assert.That(expected, Is.EqualTo(result), "Factorial of 1 should return 1.");
    }

    [Test]
    public void FactorialOfDouble_PositiveInteger_ReturnsFactorial()
    {   
        //Arrange
        double input = 4;
        double expected = 24;
        //Act
        var result = CalculatorLogic.FactorialOfDouble(input);
        //Assert
        Assert.That(expected, Is.EqualTo(result), "Factorial of 4 should return 24.");
    }
}