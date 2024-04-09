using Calculator_App;
namespace CalculatorTestProject1;

public class UnitTest10
{
    [Test]
    public void TanOfFloat_Zero_ReturnsZero()
    {
        var calculator = new CalculatorEngine();
        var result = calculator.TanOfFloat(0f);
        Assert.That(result, Is.EqualTo(0).Within(0.0001), "Tangent of 0 should be 0.");
    }

    [Test]
    public void TanOfFloat_Pi_ReturnsZero()
    {
        var calculator = new CalculatorEngine();
        var result = calculator.TanOfFloat((float)Math.PI);
        Assert.That(result, Is.EqualTo(0).Within(0.0001), "Tangent of π should be approximately 0.");
    }

    [Test]
    public void TanOfFloat_PiOverFour_ReturnsOne()
    {
        var calculator = new CalculatorEngine();
        var result = calculator.TanOfFloat((float)Math.PI / 4);
        Assert.That(result, Is.EqualTo(1).Within(0.0001), "Tangent of π/4 should be 1.");
    }

    
    [Test]
    public void TanOfFloat_NearPiOverTwo_ReturnsVeryLargeValue()
    {
        var calculator = new CalculatorEngine();
        var result = calculator.TanOfFloat((float)Math.PI / 2 - 0.01f);
        Assert.That(result > 100,Is.EqualTo(false),"Tangent near π/2 should be very large.");
    }

    [Test]
    public void TanOfFloat_ThreePiOverTwo_ReturnsVeryLargeValue()
    {
        var calculator = new CalculatorEngine();
        var result = calculator.TanOfFloat(3 * (float)Math.PI / 2 - 0.01f);
        Assert.That(result < -100,Is.EqualTo(false), "Tangent near 3π/2 should be very large and negative.");
    }

    [Test]
    public void TanOfFloat_TwoPi_ReturnsZero()
    {
        var calculator = new CalculatorEngine();
        var result = calculator.TanOfFloat(2 * (float)Math.PI);
        Assert.That(result, Is.EqualTo(0).Within(0.0001), "Tangent of 2π should be 0.");
    }
}