/*namespace Calculator_End_To_End_Tests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class Tests : PageTest
{
    
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

  
    // preq-E2E-TEST-5
    [Test]
    public async Task CalculatorWebUi_VerifyPageTitle_ReturnsCalculator()
    {  
        await Page.GotoAsync("http://localhost:5166");
        const string pageTitle = "Calculator";
      
        await Expect(Page).ToHaveTitleAsync(pageTitle);
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
        }
} */