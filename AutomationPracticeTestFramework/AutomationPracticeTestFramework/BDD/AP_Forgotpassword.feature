#Feature: AP_Forgotpassword
#	Simple calculator for adding two numbers
#
#@happy
#Scenario: Navigate to Forgot Password Page from signin page
#	Given I Am On The SignIn Page
#	When I Click The Forgot Password Btn
#	Then I Go To The Forgot Password Page "Forgot your password - My Store"
#
#
#@happy
#Scenario: Valid email
#	Given I Am On The Forgot Password Page
#	When I Click The Retrieve Password Btc With An Email "testing@snailmail.com"
#	Then I Got A Message "A confirmation email has been sent to your address: testing@snailmail.com"

#@sad
#	Given I Am On The Forgot Password Page
#	When I Click The Retrieve Password Btc With An Email "wrong"
#	Then I Got A Message "There is 1 error\r\nInvalid email address."
#
#@sad
#	Given I Am On The Forgot Password Page
#	When I Click The Retrieve Password Btc With An Email "wrong@qwe.zx"
#	Then I Got A  Message "There is 1 error\r\nThere is no account registered for this email address."