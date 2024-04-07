/*using Calculator_App;

namespace CalculatorTestProject1;

public class UnitTest5
{
    private CalculatorEngine _calculator;

  
    [Test]
    public void CompareTwoNumbers_WithExactlySameNumbers_ReturnsTrue()
    {
        var calulator = new CalculatorEngine();
        float num1 = 5.12345678f;
        float num2 = 5.12345678f;
      

        bool result = calulator.CompareTwoNumbers(num1, num2);


        Assert.IsTrue(result); 
    }

    [Test]
    public void CompareTwoNumbers_WithNumbersDifferingBeyond8thDecimal_ReturnsFalse()
    {
        var calculator = new CalculatorEngine();
        Assert.IsFalse(_calculator.CompareTwoNumbers(5.123456781f, 5.123456782f));
    }

    [Test]
    public void CompareTwoNumbers_WithNumbersDifferingWithin8thDecimal_ReturnsTrue()
    {    
        var calculator = new CalculatorEngine();
        Assert.IsTrue(_calculator.CompareTwoNumbers(5.123456781f, 5.123456780f));
    }

    [Test]
    public void CompareTwoNumbers_WithOneNumberSlightlyHigher_ReturnsTrue()
    {
        var calculator = new CalculatorEngine();
        Assert.IsTrue(_calculator.CompareTwoNumbers(5.12345678f, 5.12345679f));
    }

    [Test]
    public void CompareTwoNumbers_WithOneNumberSignificantlyHigher_ReturnsFalse()
    {    
        var calculator = new CalculatorEngine();
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
    }
} */
