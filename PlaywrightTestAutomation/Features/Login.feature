Feature: playwright  page
  As a registered user
  I want to log in to the application
  So that I can access my account

Scenario: navigate to playwright page and search for given text
    Given I navigate to the home page
    And I click on get started link
    When user click on search button
    And user enters text as "context"
    Then validate that search results are displayed
    And user clicks on "APIRequestContext" link
    And validate that "Cookie management" is displayed