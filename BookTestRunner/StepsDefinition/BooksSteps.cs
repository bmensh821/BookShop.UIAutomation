using Atata;
using Reqnroll;
using BookTest.Pages;

namespace BookTestRunner.StepsDefinition;

[Binding]
public sealed class BooksSteps
{
    private BooksPage _booksPage;

    [Given("I go to the Books page")]
    public void GivenIGoToTheBooksPage()
    {
        Go.To<BooksPage>();
    }

    [When("I select '(.*)' from the side menu")]
    public void WhenISelectFromTheSideMenu(string books)
    {
        throw new PendingStepException();
    }

    [Then("I should see all Books available with the total of '(.*)' results")]
    public void ThenIShouldSeeAllBooksAvailableWithTheTotalOfResults(string p0)
    {
        throw new PendingStepException();
    }

    [When("I locate book named '(.*)'$")]
    public void WhenILocateBookNamed(string p0)
    {
        throw new PendingStepException();
    }

    [Then("I should see the book price of '(.*)' and I can add it to the basket")]
    public void ThenIShouldSeeTheBookPriceOfAndICanAddItToTheBasket(string p0)
    {
        throw new PendingStepException();
    }

}

/*[Given("I go to the Books page")]
public void GivenIGoToTheBooksPage()
{
    _booksPage = Go.To<BooksPage>();
}

[When("I select {string} from the side menu")]
public void WhenISelectFromTheSideMenu(string category)
{
    _booksPage.ClickCategory(category);
}

[Then("I should see all Books available with the total of {string} results")]
public void ThenIShouldSeeAllBooksAvailableWithTheTotalOfResults(string expectedCount)
{
    int count = int.Parse(expectedCount);
    _booksPage.Books.Should.HaveCount(count);
}

[When("I locate book named {string}")]
public void WhenILocateBookNamed(string title)
{
    var book = _booksPage.GetBookByTitle(title);
    Assert.IsNotNull(book);
}

[Then("I should see the book price of {string} and I can add it to the basket")]
public void ThenIShouldSeeTheBookPriceOfAndICanAddItToTheBasket(string expectedPrice)
{
    var book = _booksPage.Books.FirstOrDefault();
    Assert.That(book.Price.Value, Is.EqualTo(expectedPrice));
    Assert.That(book.Availability.Content, Does.Contain("In stock"));
}*/

