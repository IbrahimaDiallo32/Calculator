using CalculatorEngine;
using NUnit.Framework;

namespace CalculatorTestProject1;

//Unit Tests for Division() Function
public class UnitTest4
{
    
    [Test]
    public void DivideTwoNumbers_TwoPositiveDoubles_ReturnsPositive()
    {
        ////preq-UNIT-TEST-5
        
        //Arrange
        double num1 = 20;
        double num2 = 5;
        double expected = 4;

        double result = CalculatorLogic.DivideTwoNumbers(num1, num2);


        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void DivideTwoNumbers_TwoNegativeDoubles_ReturnsPositive()
    {
        double num1 = -30;
        double num2 = -5;
        double expected = 6;

        double result = CalculatorLogic.DivideTwoNumbers(num1, num2);


        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void DivideTwoNumbers_PositiveDoubleByNegativeDouble_ReturnsNegative()
    {
        double num1 = 20;
        double num2 = -5;
        double expected = -4;

        double result = CalculatorLogic.DivideTwoNumbers(num1, num2);


        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void DivideTwoNumbers_NegativeDoubleByPositiveDouble_ReturnsNegative()
    {
        //Arrange
        double num1 = -20;
        double num2 = 5;
        double expected = -4;

        double result = CalculatorLogic.DivideTwoNumbers(num1, num2);


        Assert.That(expected, Is.EqualTo(result));
    }

    //Unfinished test
    [Test]
    public void Division_DoubleAndZero_ReturnsError()
    {
        //Arrange

        //Act
        double num1 = 10.0;
        double num2 = 0.0;
        //double? result = calculator.DivideTwoNumbers(num1, num2);
        double? expected = null;
        
        Exception caughtException = null;
        //Assert
        
       // Assert.That(expected, Is.EqualTo(result));
        
        
        try
        {
            // Attempt to perform division by zero
            double? result = CalculatorLogic.DivideTwoNumbers(num1, num2);
        }
        catch (Exception ex)
        {
            caughtException = ex;
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.GetType());
        }

        // Assert
        Assert.That(caughtException, Is.TypeOf<DivideByZeroException>());
    }
} 
