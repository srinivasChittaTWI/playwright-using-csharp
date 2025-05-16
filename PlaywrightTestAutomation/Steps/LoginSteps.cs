using Microsoft.Playwright;
using PlaywrightTestAutomation.Pages;
using Reqnroll;
using System.Threading.Tasks;

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
            await _loginPage.NavigateAsync("https://example.com/login");
        }

        [Given("I click on more information link")]
        public async Task WhenIClickMoreInfo()
        {
            await _loginPage.clickButton("More Information");
        }

    }
}
