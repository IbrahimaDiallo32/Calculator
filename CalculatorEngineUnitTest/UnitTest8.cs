/*using Calculator_App;
namespace CalculatorTestProject1;

public class UnitTest8
{   
    [Test]
    public void SinOfFloat_Zero_ReturnsZero()
    {
        var calculator = new CalculatorEngine();
        var result = calculator.SinOfFloat(0f);
        Assert.That(0,Is.EqualTo(result),"Sine of 0 should 0");
    }
    [Test]
    public void SinOfFloat_PiOverTwo_ReturnsOne()
    {
        var calculator = new CalculatorEngine();
        var actual = Math.Sin(Math.PI/2);
        var result = calculator.SinOfFloat((float)Math.PI / 2);
        Assert.That(result, Is.EqualTo(1).Within(0.0001), "Sine of π/2 should be 1.");
    }

    [Test]
    public void SinOfFloat_Pi_ReturnsZero()
    {
        var calculator = new CalculatorEngine();
        var result = calculator.SinOfFloat((float)Math.PI);
        Assert.That(result, Is.EqualTo(0).Within(0.0001),  "Sine of π should be 0.");
    }

    [Test]
    public void SinOfFloat_ThreePiOverTwo_ReturnsMinusOne()
    {
        var calculator = new CalculatorEngine();
        var result = calculator.SinOfFloat(3 * (float)Math.PI / 2);
        Assert.That(result, Is.EqualTo(-1).Within(0.0001),  "Sine of 3π/2 should be -1.");
    }

    [Test]
    public void SinOfFloat_TwoPi_ReturnsZero()
    {
        var calculator = new CalculatorEngine();
        var result = calculator.SinOfFloat(2 * (float)Math.PI);
        Assert.That(result, Is.EqualTo(0).Within(0.0001),  "Sine of 2π should be 0.");
    }

    [Test]
    public void SinOfFloat_NegativeInput_ReturnsCorrectValue()
    {
        var calculator = new CalculatorEngine();
        var result = calculator.SinOfFloat(-(float)Math.PI / 2);
        Assert.That(result, Is.EqualTo(-1).Within(0.001), "Sine of -π/2 should be -1.");
    }
}

    
*/