# PlaywrightTestAutomation

This repository is a robust test automation framework using Playwright, xUnit, and ReqNroll (BDD) in C#.

## Features
- **Playwright** for browser automation
- **xUnit** for test execution
- **ReqNroll** for BDD (Gherkin) support
- Page Object Model structure
- Configuration management
- Test reporting
- Parallel execution
- Reusable utilities
- Sample tests and step definitions

## Getting Started
1. Restore dependencies: `dotnet restore`
2. Build the project: `dotnet build`
3. Install Playwright browsers: `playwright install` (ensure .NET tools are in your PATH)
4. Run tests: `dotnet test`

## Folder Structure
- `Pages/` - Page Object Model classes
- `Features/` - Gherkin feature files
- `Steps/` - Step definitions for BDD
- `Tests/` - xUnit test classes
- `Utils/` - Utility and helper classes
- `Configs/` - Configuration files
- `Reports/` - Test reports output

## Notes
- Ensure your shell profile includes the .NET tools path for Playwright CLI.
- Update and expand the framework as needed for your application.
