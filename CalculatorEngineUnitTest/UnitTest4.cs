using Calculator_App;
using Calculator_App.Components.Pages;
using NUnit.Framework;

namespace CalculatorTestProject1;

public class UnitTest4
{
    
    [Test]
    public void DivideTwoNumbers_TwoPositiveFloatingPointValues_ReturnsPositive()
    {
        ////preq-UNIT-TEST-5
        
        //Arrange
        var calulator = new CalculatorEngine();
        float num1 = 20f;
        float num2 = 5f;
        float expected = 4f;

        float result = calulator.DivideTwoNumbers(num1, num2);


        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void DivideTwoNumbers_TwoNegativeFloatingPointValues_ReturnsPositive()
    {
        var calulator = new CalculatorEngine();
        float num1 = -30f;
        float num2 = -5f;
        float expected = 6f;

        float result = calulator.DivideTwoNumbers(num1, num2);


        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void DivideTwoNumbers_PositiveFloatByNegativeFloat_ReturnsNegative()
    {
        var calulator = new CalculatorEngine();
        float num1 = 20f;
        float num2 = -5f;
        float expected = -4f;

        float result = calulator.DivideTwoNumbers(num1, num2);


        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void DivideTwoNumbers_NegativeFloatByPositiveFloat_ReturnsNegative()
    {
        //Arrange
        var calulator = new CalculatorEngine();
        float num1 = -20f;
        float num2 = 5f;
        float expected = -4f;

        float result = calulator.DivideTwoNumbers(num1, num2);


        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Division_FloatingPointValueAndZero_ReturnsError()
    {
        //Arrange
        CalculatorEngine calculator = new CalculatorEngine();

        //Act
        float num1 = 10.0f;
        float num2 = 0.0f;
        //double? result = calculator.DivideTwoNumbers(num1, num2);
        float? expected = null;
        
        Exception caughtException = null;
        //Assert
        
       // Assert.That(expected, Is.EqualTo(result));
        
        
        try
        {
            // Attempt to perform division by zero
            double? result = calculator.DivideTwoNumbers(num1, num2);
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
