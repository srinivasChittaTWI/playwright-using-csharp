using Microsoft.Playwright;
using System.Threading.Tasks;

namespace PlaywrightTestAutomation.Pages
{
    public class LoginPage
    {
        private readonly IPage _page;
        public LoginPage(IPage page) => _page = page;

        public async Task NavigateAsync(string url) => await _page.GotoAsync(url);
        public async Task EnterUsername(string username) => await _page.FillAsync("#username", username);
        public async Task EnterPassword(string password) => await _page.FillAsync("#password", password);
        public async Task ClickLogin() => await _page.ClickAsync("#login");
        public async Task<bool> IsLoggedIn() => await _page.IsVisibleAsync("#logout");

        public async Task clickButton(string v)
        {
            await _page.Locator("text=" + v).ClickAsync();
        }
    }
}
