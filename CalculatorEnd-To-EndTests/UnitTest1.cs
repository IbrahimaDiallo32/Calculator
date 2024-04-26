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
        var isCorrectResult = Expect(Page.GetByText("Invalid Input, Numbers Only")).ToBeVisibleAsync();
    }

    [Test]
    public async Task CalculatorWebUi_DivideFloatingPointValueAndZero_ReturnsNotANumberError()
    {
        await Page.ReloadAsync();
        
        await Page.GotoAsync("http://localhost:5166");
        await Page.GetByLabel("firstInput").FillAsync("3");
        await Page.GetByLabel("secondInput").FillAsync("5");
        await Page.ClickAsync("text ='A / B'");
        var isCorrectResult = Expect(Page.GetByText("Not a Number")).ToBeVisibleAsync();
    }
    
    [Test]
    public async Task irrevelant_test()
    {
        await Page.GotoAsync("http://localhost:5166");
        await Page.FillAsync("#firstInput", "5");
        await Page.FillAsync("#spaceIndentForInputBox", "3");
        await Page.ClickAsync("text =A + B");

        
// Wait for the result element to appear
        //var result = await Page.InnerTextAsync("#resultBoxForCorrectInput");
        var resultElement = await Page.QuerySelectorAsync("#realResult");
        
        
        if (resultElement != null)
        {
            string resultTexts = await resultElement.InnerTextAsync();
            Console.WriteLine(resultTexts);
        }
        else
        {
            Console.WriteLine("Element with ID '#realResult' not found!");
        }
        //await Page.WaitForSelectorAsync("#realResult");
        string resultText = await resultElement.InnerTextAsync();
        Console.WriteLine(resultText);
        
        
        if (resultElement != null)
        {
            Console.WriteLine("not null");
        }
        else
        {
            Console.WriteLine("resultElement is null! The element might not exist or might not be visible after the button click.");
        }
        }
} 