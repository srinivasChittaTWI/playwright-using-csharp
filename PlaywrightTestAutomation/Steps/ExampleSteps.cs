
using System.Threading.Tasks;
using Microsoft.Playwright;
using PlaywrightTestAutomation.Pages;
using Reqnroll;

namespace PlaywrightTestAutomation.Steps
{

    [Binding]
    public class ExampleSteps
    {
        private readonly ScenarioContext _context;
        private IPage _page;
        private GooglePage _googlePage;
        private AmazonPage _amazonPage;


        public ExampleSteps(ScenarioContext context)
        {
            _context = context;
        }

        [Given("user navigates to {string}")]
        public async Task GivenUserNavigatesTo(string p0)
        {
            _page = (IPage)_context["Page"];
            _googlePage = new GooglePage(_page);
           await  _googlePage.NavigateAsync("https://www.amazon.com/");
        }

        [Given("user search for {string}")]
        public async Task GivenUserSearchFor(string amazon)
        {
           await _googlePage.EnterSearch(amazon);
           await _googlePage.ClickSearchButton();
        }

        [When("user clicks on first search result")]
        public async Task WhenUserClicksOnFirstSearchResult()
        {
          await  _googlePage.IsResultDisplayed();
           await _googlePage.ClickFirstSearchResult();
        }

        [Then("validate that mac book image is loaded")]
        public async Task ThenValidateThatAmazonLogoIsLoaded()
        {
            _page = (IPage)_context["Page"];
            _amazonPage = new AmazonPage(_page);
           await _amazonPage.IsLogoDisplayed();
             
         }
    }
}
