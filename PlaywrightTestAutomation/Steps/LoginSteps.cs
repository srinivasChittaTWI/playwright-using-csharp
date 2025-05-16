using Allure.Xunit.Attributes;
using Allure.Xunit.Attributes.Steps;
using Microsoft.Playwright;
using PlaywrightTestAutomation.Pages;
using Reqnroll;

namespace PlaywrightTestAutomation.Steps
{
    [AllureSuite("Login Suite")]
    [AllureFeature("Login Feature")]
    [Binding]
    public class LoginSteps
    {
        private readonly ScenarioContext _context;
        private IPage _page;
        private LoginPage _loginPage;

        public LoginSteps(ScenarioContext context)
        {
            _context = context;
        }
        
       
        [Given("I navigate to the home page")]
        public async Task GivenINavigateToTheLoginPage()
        {
            _page = (IPage)_context["Page"];
            _loginPage = new LoginPage(_page);
            await _loginPage.NavigateAsync("https://playwright.dev/");
        }
       
        [Given("I click on get started link")]
        public async Task WhenIClickMoreInfo()
        {
            await _loginPage.clickButton("Get started");
        }
    }
}
