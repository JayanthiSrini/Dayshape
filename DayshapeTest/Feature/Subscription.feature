Feature: Subscription test

@Valid
Scenario: Subscribing to newsletter with valid email id
	Given I am on the homepage
	And I enter a valid email address for subscription
	When I click on the subscribe button
	Then I see a successful message

@Invalid
Scenario: Subscribing to newsletter with invalid email id
   Given I am on the homepage
   And I enter an invalid email address for subscription
   When I click on the subscribe button
   Then I see an error message

@Invalid
Scenario: Subscribing to newsletter without entering email id
   Given I am on the homepage
   And I don't enter any email address
   When I click on the subscribe button
   Then I see an empty field validation message
 