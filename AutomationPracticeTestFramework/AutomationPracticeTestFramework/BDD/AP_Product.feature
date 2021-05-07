Feature: AP_Product
	As a user of the automationpractice website
	I want to add products to my cart
	So that I can buy items

@mytag
Scenario: Add a product to the cart
	Given I am on the homepage
	And I click the T-shirts tab 
	When I add a T-shirt to the cart
	Then I get a success alert "Product successfully added to your shopping cart"

	@mytag
Scenario: Buy the product added to cart
	Given I am on the homepage
	And I click the T-shirts tab 
	And I added a T-shirt to basket
	And I click the proceed to checkout button
	And I click to proceed to the sign in page
	And I enter an email address "test@sparta.com"
	And I enter a password "sparta"
	When I click sign in
	Then I see address information "Sparta Global"