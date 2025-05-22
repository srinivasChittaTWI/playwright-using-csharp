using System.Threading.Tasks;
using Allure.Xunit.Attributes;
using Allure.Xunit.Attributes.Steps;
using Microsoft.Playwright;
using PlaywrightTestAutomation.Pages;
using Reqnroll;

namespace PlaywrightTestAutomation.Steps
{

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

        [When("user click on search button")]
        public async Task WhenUserClickOnSearchButton()
        {
            await _loginPage.ClickButton("Search");
        }

        [When("user enters text as {string}")]
        public async Task WhenUserEntersTextAs(string context)
        {
            await _loginPage.EnterText(context);
        }

        [Then("validate that search results are displayed")]
        public async Task ThenValidateThatSearchResultsAreDisplayed()
        {
            await _loginPage.ValidateSearchResults();
        }

        [Then("user clicks on {string} link")]
        public async Task ThenUserClicksOnLink(string p0)
        {
            await _loginPage.ClickLink(p0);
        }
         
        [Then("validate that {string} is displayed")]
         public async Task ThenValidateThatIsDisplayed(string p0)
         {
             await _loginPage.ValidateTextDisplayed(p0);
         } 
    }
}
