using Microsoft.Playwright;
using System.Threading.Tasks;

namespace PlaywrightTestAutomation.Pages
{
    public class AmazonPage
    {
        private readonly IPage _page;
        public AmazonPage(IPage page) => _page = page;

        public async Task NavigateAsync(string url) => await _page.GotoAsync(url);
        public async Task<bool> IsLogoDisplayed() => await _page.IsVisibleAsync("#nav-logo");
    }
}
