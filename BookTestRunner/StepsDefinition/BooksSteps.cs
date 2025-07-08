using Atata;
using static BookTest.Controls.AtataShortcuts;
using NUnit.Framework;
using Reqnroll;
using BookTest.UI.Pages;

namespace BookTestRunner.StepsDefinition;


[Binding]
public sealed class BooksSteps
{
    private readonly ScenarioContext _scenarioContext;

    public BooksSteps(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    private BooksPage _booksPage;

    [Given("I go to the Books page")]
    public void GivenIGoToTheBooksPage()
    {
        Go.To<BooksPage>();
    }

    [When("I select '(.*)' from the side menu")]
    public void WhenISelectFromTheSideMenu(string category)
    {
        On<BooksPage>().ClickCategory(category);
    }

    [Then("I should see all Books available with the total of '(.*)' results")]
    public void ThenIShouldSeeAllBooksAvailableWithTheTotalOfResults(string bookCounts)
    {
        int count = int.Parse(bookCounts);
        On<BooksPage>().BooksCount.Content.Equals(bookCounts);
    }

    [When("I locate book named '(.*)'$")]
    public void WhenILocateBookNamed(string title)
    {
        _scenarioContext.Set(title, "title");
        On<BooksPage>().GetBookByTitle(title);
    }

    [Then("I should see the book price of '(.*)' and I can add it to the basket")]
    public void ThenIShouldSeeTheBookPriceOfAndICanAddItToTheBasket(string expectedPrice)
    {
        var page = On<BooksPage>();
        var actualPrice = page.GetBookPrice(_scenarioContext.Get<string>("title"));

        Assert.That(actualPrice, Is.EqualTo($"£{expectedPrice}"));
        Assert.That(page.IsBookInStock(_scenarioContext.Get<string>("title")), Is.True);
    }
}
