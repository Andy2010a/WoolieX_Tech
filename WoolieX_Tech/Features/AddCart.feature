Feature: AddCart


Scenario: Add Products to cart
	Given I have Navigated to site
	When I Click on Signin link
	And  I use valid credentials
    Then I should login
	When I add products to cart
    Then I can Place the order

