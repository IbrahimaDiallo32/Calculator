using CalculatorEngine;

namespace CalculatorTestProject1;
//preq-ENGINE-8

public class UnitTest5
{
    
    [Test]
    public void CompareTwoNumbers_WithExactlySameNumbers_ReturnsTrue()
    {
        //preq-ENGINE-8
        //Arrange
        double num1 = 0.3333333;
        double num2 = 0.3333333;
        
        //Act
        double result = CalculatorLogic.CompareTwoNumbers(num1, num2);
        
        //Assert
        Assert.That(result, Is.EqualTo(1)); 
    }

    [Test]
    public void CompareTwoNumbers_WithNumbersDifferingBeyond8thDecimal_ReturnssTrue()
    {
        //Arrange
        double num1 = 0.333333331;
        double num2 = 0.333333332;
        
        //Act
        double result = CalculatorLogic.CompareTwoNumbers(num1, num2);

        //Assert
        Assert.That(result, Is.EqualTo(1));
    }

    [Test]
    public void CompareTwoNumbers_WithNumbersDifferingAt8thDecimal_ReturnsFalse()
    {
        //Arrange
        double num1 = 0.33333333;
        double num2 = 0.33333334;
        
        //Act
        double result = CalculatorLogic.CompareTwoNumbers(num1, num2);

        //Assert
        Assert.That(result, Is.EqualTo(0));
    }
    
    [Test]
    public void CompareTwoNumbers_WithNegativeNumbers_ReturnsTrue()
    {
        //Arrange
        double num1 = -0.333333331;
        double num2 = -0.333333332;
        
        //Act
        double result = CalculatorLogic.CompareTwoNumbers(num1, num2);

        //Assert
        Assert.That(result, Is.EqualTo(1));
    }
} 