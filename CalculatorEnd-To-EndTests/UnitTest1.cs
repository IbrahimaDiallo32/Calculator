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
        const string pageTitle = "Calculator";
        await Page.GotoAsync("http://localhost:5166");
        await Expect(Page).ToHaveTitleAsync(pageTitle);
    }

    [Test]
    public async Task whatter()
    {
        //refresh page
        await Page.ReloadAsync();

        //load webpage
        await Page.GotoAsync("http://localhost:5166");

        //values into A and B
        //await Page.GetByLabel("firstInput").FillAsync("5");

        //await Page.GetByLabel("secondInput").FillAsync("3");
        //await Page.FillAsync("#firstInput", "5");
        //await Page.FillAsync("#spaceIndentForInputBox", "3");
        await Page.GetByLabel("firstInput").FillAsync("3");
        await Page.GetByLabel("secondInput").FillAsync("5");
        //await Page.GetByLabel("firstInput", new() { Exact = true }).FillAsync("5");
       //await Page.GetByLabel("spaceIndentForInputBox", new() { Exact = true }).FillAsync("7");

        //add button
        //await Page.GetByLabel("add", new() { Exact = true }).ClickAsync();

        await Page.ClickAsync("text ='A + B'");
        //await Page.GetByRole(AriaRole.Button, new() { Name = "A + B" }).ClickAsync();

    //get result
    var isCorrectResult = Expect(Page.GetByText("8")).ToBeVisibleAsync();
    //var isCorrectResult = await Page.Locator("text='8'").IsVisibleAsync();
    Console.WriteLine(isCorrectResult);
    //Assert.That(isCorrectResult, Is.EqualTo(true));
    //await Expect(Page.GetByText("8")).ToBeVisibleAsync();
}
    
    [Test]
    public async Task CalculatorWebUI_AddTwoFloatingPointValues_ReturnsSumOfValues()
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
        await Page.WaitForSelectorAsync("#realResult");
        string resultText = await resultElement.InnerTextAsync();
        Console.WriteLine(resultText);
        /*var resultElement = await Page.QuerySelectorAsync("#realResult"); 
        Console.WriteLine("hiiii");
        Console.WriteLine(resultElement);*/
        
        if (resultElement != null)
        {
            Console.WriteLine("not null");
        }
        else
        {
            Console.WriteLine("resultElement is null! The element might not exist or might not be visible after the button click.");
        }
        // actualResult = await resultElement.EvaluateAsync<double>("element => element.textContent");
        //string resultText = await resultElement.TextContentAsync();
        //double result = double.Parse(resultElement);
        //double result = 8;
        
        
       //await Page.WaitForSelectorAsync("#resultBox");

// Get the text content containing the result
        //var resultElement = await Page.QuerySelectorAsync("#resultBoxForCorrectInput");
        //string resultText = await resultElement.TextContentAsync();

        //int result = int.Parse(resultText);
        //Assert.Equals(8, result);
        /*await Page.GotoAsync("http://localhost:5166");
        await Page.FillAsync("#firstInput", "5");
        await Page.FillAsync("#spaceIndentForInputBox", "3");
        await Page.ClickAsync("text =A + B");
        // ... your existing code ...

// 1. Get the text content containing the result
        var resultElement = await Page.QuerySelectorAsync("#resultBoxForCorrectInput"); // Adjust selector if needed
        string resultText = await resultElement.TextContentAsync();

// 2. Convert the text to an integer for comparison
        int result = int.Parse(resultText);

// 3. Check if the result equals 8
        Assert.Equals(8, result);
        //var result = await Page.InnerTextAsync("#resultBoxForCorrectInput");
        //Assert.Equals(result, 8);*/
    }
        /*
        [Test]
        public async Task HomepageHasPlaywrightInTitleAndGetStartedLinkLinkingtoTheIntroPage()
        {
            await Page.GotoAsync("https://playwright.dev");

            // Expect a title "to contain" a substring.
            await Expect(Page).ToHaveTitleAsync(new Regex("Playwright"));

            // create a locator
            var getStarted = Page.Locator("text=Get Started");

            // Expect an attribute "to be strictly equal" to the value.
            await Expect(getStarted).ToHaveAttributeAsync("href", "/docs/intro");

            // Click the get started link.
            await getStarted.ClickAsync();

            // Expects the URL to contain intro.
            await Expect(Page).ToHaveURLAsync(new Regex(".*intro"));
        }
        */

  
    // preq-E2E-TEST-5
    /*[Test]
    public async Task CalculatorWebUi_VerifyPageTitle_ReturnsCalculator()
    {  
        await Page.GotoAsync("http://localhost:5166");
        const string pageTitle = "Calculator";
      
        await Expect(Page).ToHaveTitleAsync(pageTitle);*/
        /*Assert.That(await Page.TitleAsync(),Is.EqualTo("Calculator"));
    }
}  
// preq-E2E-TEST-6
        [Test]
        public async Task CalculatorWebUi_AddTwoFloatingPointValues_ReturnsSumOfValues()
        {
            await Page.GotoAsync("http://localhost:5166");
            
            await Page.FillAsync("#inputA", "5");
            await Page.FillAsync("#inputB", "3");
            await Page.ClickAsync("#addButton");
            var result = await Page.InnerTextAsync("#resultBox");
            
        }
        //preq-E2E-TEST-7
        [Test]
        public async Task CalculatorWebUi_DivideFloatingPointValueAndZero_ReturnsNotANumberError()
        {
            await Page.GotoAsync("http://localhost:5166");
            await Page.FillAsync("#inputA", "25");
            await Page.FillAsync("#inputB", "0");
            await Page.ClickAsync("#divideButton");
            var result = await Page.InnerTextAsync("#resultBox");
            Assert.AreEqual("Not a Number", result);
        }*/
} 