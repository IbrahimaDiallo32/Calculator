using CalculatorEngine;
using NUnit.Framework;

namespace CalculatorTestProject1;

//Unit Tests for Division() Function
//preq-ENGINE-7
public class DivisionUnitTest
{
    
    [Test]
    public void DivideTwoNumbers_TwoPositiveDoubles_ReturnsPositive()
    {
        ////preq-UNIT-TEST-5
        
        //Arrange
        double num1 = 20;
        double num2 = 5;
        double expected = 4;
        //act
        double result = CalculatorLogic.DivideTwoNumbers(num1, num2);
        //Assert
        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void DivideTwoNumbers_TwoNegativeDoubles_ReturnsPositive()
    {   
        //Arrange
        double num1 = -30;
        double num2 = -5;
        double expected = 6;
        //Act
        double result = CalculatorLogic.DivideTwoNumbers(num1, num2);
        //Assert
        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void DivideTwoNumbers_PositiveDoubleByNegativeDouble_ReturnsNegative()
    {   
        //Arrange
        double num1 = 20;
        double num2 = -5;
        double expected = -4;
        //Act
        double result = CalculatorLogic.DivideTwoNumbers(num1, num2);
        //Assert
        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void DivideTwoNumbers_NegativeDoubleByPositiveDouble_ReturnsNegative()
    {
        //Arrange
        double num1 = -20;
        double num2 = 5;
        double expected = -4;
        //Act
        double result = CalculatorLogic.DivideTwoNumbers(num1, num2);
        //Assert
        Assert.That(expected, Is.EqualTo(result));
    }
    [Test]
    //preq-UNIT-TEST-6
    public void Division_DivideByZero_ReturnsInfiniteError()
    {
        // Arrange
        double num1 = 10;
        double num2 = 0;
        // Act
        double result = CalculatorLogic.DivideTwoNumbers(num1, num2);
        // Assert
        Assert.That(double.IsInfinity(result),Is.EqualTo(true), "Division by 0 should result in an error.");

    }
} 
