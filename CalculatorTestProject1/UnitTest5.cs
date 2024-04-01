using Calculator_App;

namespace CalculatorTestProject1;

public class UnitTest5
{
    private CalculatorEngine _calculator;

    [SetUp]
    public void SetUp()
    {
        _calculator = new CalculatorEngine();
    }

    [Test]
    public void CompareTwoNumbers_WithExactlySameNumbers_ReturnsTrue()
    {
        Assert.IsTrue(_calculator.CompareTwoNumbers(5.12345678f, 5.12345678f));
    }

    [Test]
    public void CompareTwoNumbers_WithNumbersDifferingBeyond8thDecimal_ReturnsFalse()
    {
        Assert.IsFalse(_calculator.CompareTwoNumbers(5.123456781f, 5.123456782f));
    }

    [Test]
    public void CompareTwoNumbers_WithNumbersDifferingWithin8thDecimal_ReturnsTrue()
    {
        Assert.IsTrue(_calculator.CompareTwoNumbers(5.123456781f, 5.123456780f));
    }

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
    }
}
