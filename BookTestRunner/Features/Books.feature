Feature: Books
This featre file is focusing on the Books page, and search Books available in ALL category.

Scenario: Main Books page
	Given I go to the Books page
	When I select 'Books' from the side menu
	Then I should see all Books available with the total of '1000' results
	# the 'Then' step can be reuseable for other categories elected by user 
	# but if the total result is update, this step should be updated as well

Scenario: Add a book to the basket
	Given I go to the Books page
	When I locate book named 'A Light in the Attic'
	Then I should see the book price of '51.77' and I can add it to the basket

Scenario Outline: Add multiple books to the basket
	Given I go to the Books page
	When I locate book named '<book_name>'
	Then I should see the book price of '<book_price>' and I can add it to the basket
	# if the book is not on the current page, click next and search until the book is found
Examples:
	| book_name            | book_price |
	| A Light in the Attic | 51.77      |
	| The Black Maria      | 52.15      |
	| Sophie's World       | 15.94      |
	| Security             | 29.25      |
