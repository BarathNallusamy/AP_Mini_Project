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

Scenario: Sign in from cart to see delivery info
	Given I added a T-shirt to basket
	And I click the proceed to checkout button
	And I click to proceed to the sign in page
	And I enter an email address "test@sparta.com"
	And I enter a password "sparta"
	When I click sign in
	Then I see address information "Sparta Global"

Scenario: Get order confirmation
	Given I added a T-shirt to basket
	And I click the proceed to checkout button
	And I click to proceed to the sign in page
	And I enter an email address "test@sparta.com"
	And I enter a password "sparta"
	And I click sign in
	And I click the proceed to shipping 
	And I click the checkbox
	And I click bankwire payment
	When I click confirm payment
	Then I will see the confirmation message "Your order on My Store is complete"