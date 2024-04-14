/*using Calculator_App;
namespace CalculatorTestProject1;

public class UnitTest9
{
    [Test]
    public void CosOfFloat_Zero_ReturnsOne()
    {
        var calculator = new CalculatorEngine();
        var result = calculator.CosOfFloat(0f);
        Assert.That(result,Is.EqualTo(1).Within(0.0001),"Cosine of 0 should be 1.");
    }
    [Test]
    public void CosOfFloat_PiOverTwo_ReturnsZero()
    {
        var calculator = new CalculatorEngine();
        var result = calculator.CosOfFloat((float)Math.PI / 2);
        Assert.That(result, Is.EqualTo(0).Within(0.0001), "Cosine of π/2 should be 0.");
    }

    [Test]
    public void CosOfFloat_Pi_ReturnsMinusOne()
    {
        var calculator = new CalculatorEngine();
        var result = calculator.CosOfFloat((float)Math.PI);
        Assert.That(result, Is.EqualTo(-1).Within(0.0001), "Cosine of π should be -1.");
    }

    [Test]
    public void CosOfFloat_ThreePiOverTwo_ReturnsZero()
    {
        var calculator = new CalculatorEngine();
        var result = calculator.CosOfFloat(3 * (float)Math.PI / 2);
        Assert.That(result, Is.EqualTo(0).Within(0.0001), "Cosine of 3π/2 should be 0.");
    }

    [Test]
    public void CosOfFloat_TwoPi_ReturnsOne()
    {
        var calculator = new CalculatorEngine();
        var result = calculator.CosOfFloat(2 * (float)Math.PI);
        Assert.That(result, Is.EqualTo(1).Within(0.0001), "Cosine of 2π should be 1.");
    }

    [Test]
    public void CosOfFloat_NegativeInput_ReturnsCorrectValue()
    {
        var calculator = new CalculatorEngine();
        var result = calculator.CosOfFloat(-(float)Math.PI / 2);
        Assert.That(result, Is.EqualTo(0).Within(0.0001), "Cosine of -π/2 should be 0.");
    }
    
}*/