using Microsoft.Playwright;
using System.Threading.Tasks;

namespace PlaywrightTestAutomation.Pages
{
    public class GooglePage
    {
        private readonly IPage _page;
        public GooglePage(IPage page) => _page = page;

        public async Task NavigateAsync(string url) => await _page.GotoAsync(url);
        public async Task EnterSearch(string searchTerm) => await _page.FillAsync("textarea[name='q']", searchTerm);
        public async Task ClickSearchButton() => await _page.ClickAsync("input[name='btnK']");
        public async Task ClickFirstSearchResult() => await _page.Locator("//*[@id='tads']/div[3]/div/div/div/div/div[1]/a/div[1]").ClickAsync();
        public async Task<bool> IsResultDisplayed() => await _page.IsVisibleAsync("#result-stats");
    }
}
