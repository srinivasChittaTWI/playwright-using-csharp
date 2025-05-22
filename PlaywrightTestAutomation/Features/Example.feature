Feature: search for macbook in amazon

Scenario: launch amazon and search for mac book
Given user navigates to "amazon.com"
And user search for "mac book"
When user clicks on first search result
Then validate that mac book image is loaded