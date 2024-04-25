using CalculatorEngine;

namespace CalculatorTestProject1;
//Unit Tests For Factorial //

public class FactorialUnitTest
{
    [Test]
    public void FactorialOfDouble_Zero_ReturnsOne()
    {   
        //preq-UNIT-TEST-15
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
    //preq-UNIT-TEST-14
    public void FactorialOfDouble_PositiveInteger_ReturnsFactorial()
    {   
        //Arrange
        double input = 5;
        double expected = 120;
        //Act
        var result = CalculatorLogic.FactorialOfDouble(input);
        //Assert
        Assert.That(expected, Is.EqualTo(result), "Factorial of 5 should return 120.");
    }
    [Test]
    public void FactorialOfDouble_OddNegativeInteger_ReturnsNegativeFactorial()
    {   
        //Arrange
        double input = -5;
        double expected = -120;
        //Act
        var result = CalculatorLogic.FactorialOfDouble(input);
        //Assert
        Assert.That(expected, Is.EqualTo(result), "Factorial of -5 should return -120.");
    }
}