Feature: AP_Checkout
	Simple calculator for adding two numbers

@happy
Scenario: Whole journey 
Given I am on the homepage and I sign in and add t shirt to the cart
And go to checkout page
And click proceed to checkout (to step 2)




Then I move to the Tshirt results page

@happy
Scenario: checkout go to step 2
Given I am on the summary tab of the checkout
When I click proceed to checkout 
Then I proceed to the sign in tab