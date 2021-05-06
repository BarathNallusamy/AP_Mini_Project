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