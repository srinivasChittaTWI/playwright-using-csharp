using FluentAssertions;
using Microsoft.Playwright;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

namespace PlaywrightTestAutomation.Pages
{
    public class LoginPage
    {
        private readonly IPage _page;
        public LoginPage(IPage page) => _page = page;

        public async Task NavigateAsync(string url) => await _page.GotoAsync(url);

        public async Task clickButton(string v)
        {
            await _page.Locator("text=" + v).ClickAsync();
        }
        public async Task ClickButton(string buttonText)
        {
            var button = _page.Locator("//span[contains(text(),'Search')]");
            await button.ClickAsync();
        }
        public async Task ClickLink(string linkText)
        {
            var link = _page.Locator($"span:has-text('{linkText}')");
            await link.ClickAsync();
        }
        public async Task EnterText(string text)
        {
            var field = _page.Locator("#docsearch-input");
            await field.FillAsync(text);
        }

        public async Task ValidateSearchResults()
        {
            var searchResults = _page.Locator(".DocSearch-Dropdown");
            var isVisible = await searchResults.IsVisibleAsync();
            isVisible.Should().BeTrue("Search results should be displayed.");

        }

        public async Task ValidateTextDisplayed(string text)
        {

            var element = _page.Locator($"text={text}");
            var isVisible = await element.IsVisibleAsync();
            isVisible.Should().BeTrue($"The text '{text}' should be displayed on the page.");
        }
    }
}
