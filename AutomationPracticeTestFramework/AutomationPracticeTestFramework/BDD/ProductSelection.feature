Feature: ProductSelection
	As a registered user of the Automation Practice Website
	I want to be able to select a product category
	So that I can buy a specific item

@Happy_path
Scenario: Navigate to thirt page
	Given I am on the home page
	When I click the tshirt button from navigation pane
	Then I should be able to navigate to the tshirt page


@Happy_path
Scenario: Select a product from tshirt page
	Given I am on the tshirt category page
	When I select to view a product
	Then I should be able to navigate to the product page


@Happy_path
Scenario: Add a product to the cart
	When I add the product to the cart
	Then I should receive a Product successfully added to your shopping cart message