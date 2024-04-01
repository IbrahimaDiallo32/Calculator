using Calculator_App;

namespace CalculatorTestProject1;

public class UintTest4
{
    private CalculatorEngine _calculator;

    [SetUp]
    public void SetUp()
    {
        _calculator = new CalculatorEngine();
    }

    [Test]
    public void DivideTwoNumbers_BothPositive_ReturnsPositive()
    {
        Assert.AreEqual(2, _calculator.DivideTwoNumbers(10, 5));
    }

    [Test]
    public void DivideTwoNumbers_BothNegative_ReturnsPositive()
    {
        Assert.AreEqual(2, _calculator.DivideTwoNumbers(-10, -5));
    }

    [Test]
    public void DivideTwoNumbers_PositiveByNegative_ReturnsNegative()
    {
        Assert.AreEqual(-2, _calculator.DivideTwoNumbers(10, -5));
    }

    [Test]
    public void DivideTwoNumbers_NegativeByPositive_ReturnsNegative()
    {
        Assert.AreEqual(-2, _calculator.DivideTwoNumbers(-10, 5));
    }

    [Test]
    public void DivideTwoNumbers_ByZero_ReturnsNaN()
    {
        Assert.IsTrue(float.IsNaN(_calculator.DivideTwoNumbers(10, 0)));
    }
}
}
