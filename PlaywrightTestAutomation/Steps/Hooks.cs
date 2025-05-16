using System.Threading.Tasks;
using Microsoft.Playwright;
using Reqnroll;

namespace PlaywrightTestAutomation.Steps
{
    [Binding]
    public class Hooks
    {
        private readonly ScenarioContext _context;
        private IPage? _page;
        private IBrowser? _browser;

        public Hooks(ScenarioContext context)
        {
            _context = context;
        }

        [BeforeScenario]
        public async Task BeforeScenarioAsync()
        {
            var playwright = await Playwright.CreateAsync();
            _browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            _page = await _browser.NewPageAsync();
            _context["Page"] = _page;
        }

        [AfterScenario]
        public async Task AfterScenarioAsync()
        {
            if (_page != null) await _page.CloseAsync();
            if (_browser != null) await _browser.CloseAsync();
        }
    }
}
