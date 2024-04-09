using Calculator_App;

namespace CalculatorTestProject1;

public class UnitTest5
{
    private CalculatorEngine _calculator = new CalculatorEngine();
    // preq-UNIT-TEST-7
    [Test]
    public void CompareTwoNumbers_WithExactlySameNumbers_ReturnsTrue()
    {
        //Arrange
        float num1 = 0.333333f;
        float num2 = 0.333333f;
        
        //Act
        bool result = _calculator.CompareTwoNumbers(num1, num2);
        
        //Assert
        Assert.That(result, Is.EqualTo(true));
    }

    [Test]
    public void CompareTwoNumbers_WithNumbersDifferingBeyond7thDecimal_ReturnsFalse()
    {
        //Arrange
        float num1 = 0.33333333f;
        float num2 = 0.33333334f;
        
        //Act
        bool result = _calculator.CompareTwoNumbers(num1, num2);

        //Assert
        Assert.That(result, Is.EqualTo(false));
    }

    [Test]
    public void CompareTwoNumbers_WithNumbersDifferingAfter7thDecimal_ReturnsTrue()
    {
        //Arrange
        float num1 = 0.333333331f;
        float num2 = 0.333333332f;
        
        //Act
        bool result = _calculator.CompareTwoNumbers(num1, num2);

        //Assert
        Assert.That(result, Is.EqualTo(true));
    }

    /*
    [Test]
    public void CompareTwoNumbers_WithOneNumberSlightlyHigher_ReturnsTrue()
    {
        Assert.IsTrue(_calculator.CompareTwoNumbers(5.12345678f, 5.12345679f));
    }

    [Test]
    public void CompareTwoNumbers_WithOneNumberSignificantlyHigher_ReturnsFalse()
    {
        Assert.IsFalse(_calculator.CompareTwoNumbers(5.12345678f, 5.12345670f));
    }

    [Test]
    public void CompareTwoNumbers_WithNegativeNumbers_ReturnsTrue()
    {
        Assert.IsTrue(_calculator.CompareTwoNumbers(-5.12345678f, -5.12345678f));
    }

    [Test]
    public void CompareTwoNumbers_WithOnePositiveAndOneNegativeNumber_ReturnsFalse()
    {
        Assert.IsFalse(_calculator.CompareTwoNumbers(-5.12345678f, 5.12345678f));
    }*/
} 