using Microsoft.Playwright;
using NUnit.Framework;

namespace Calculator_End_To_End_Tests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class UnitTests : PageTest
{

    [Test]
    public async Task CalculatorWebUI_VerifyPageTitle_ReturnsCalculator()
    {
        //preq-E2E-TEST-5
        const string pageTitle = "Calculator";
        await Page.GotoAsync("http://localhost:5166");
        await Expect(Page).ToHaveTitleAsync(pageTitle);
    }

    [Test]
    public async Task CalculatorWebUI_AddTwoFloatingPointValues_ReturnsSumOfValues()
    {
        //preq-E2E-TEST-6
        //refresh page
        await Page.ReloadAsync();
        await Page.GotoAsync("http://localhost:5166");
        await Page.GetByLabel("firstInput").FillAsync("3");
        await Page.GetByLabel("secondInput").FillAsync("5");
        await Page.ClickAsync("text ='A + B'");

    //get result
    var isCorrectResult = Expect(Page.GetByText("8")).ToBeVisibleAsync();
    Console.WriteLine(isCorrectResult);
}

    [Test]
    public async Task CalculatorWebUI_OnlyOneValidInput_ReturnsInvalidInputWhenRequestingFunctionRequiringTwoInputs()
    {
        //preq-E2E-TEST-8
        await Page.ReloadAsync();
        
        await Page.GotoAsync("http://localhost:5166");
        await Page.GetByLabel("firstInput").FillAsync("3");
        await Page.ClickAsync("text ='A * B'");
        var isCorrectResult = Expect(Page.GetByText("Invalid Input, Numbers Only")).ToBeVisibleAsync();
    }

    [Test]
    public async Task CalculatorWebUi_DivideFloatingPointValueAndZero_ReturnsNotANumberError()
    {
        //preq-E2E-TEST-7
        await Page.ReloadAsync();
        
        await Page.GotoAsync("http://localhost:5166");
        await Page.GetByLabel("firstInput").FillAsync("3");
        await Page.GetByLabel("secondInput").FillAsync("0");
        await Page.ClickAsync("text ='A / B'");
        var isCorrectResult = Expect(Page.GetByText("Not a Number")).ToBeVisibleAsync();
    }

    [Test]
    public async Task CalculatorWebUi_ClearInputsInTextBoxes_ReturnsToDefaultPage()
    {
        await Page.ReloadAsync();
        
        await Page.GotoAsync("http://localhost:5166");
        await Page.GetByLabel("firstInput").FillAsync("7");
        await Page.GetByLabel("secondInput").FillAsync("5");
        await Page.ClickAsync("text ='A + B'");
        await Page.ClickAsync("text ='Clear'");
    }
} 