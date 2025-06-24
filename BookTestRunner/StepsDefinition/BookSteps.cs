using Reqnroll;

namespace BookTestRunner.StepsDefinition;

public sealed class BookSteps
{
    [Given("I go to the Books page")]
    public void GivenIGoToTheBooksPage()
    {
        throw new PendingStepException();
    }

    [When("I select {string} from the side menu")]
    public void WhenISelectFromTheSideMenu(string books)
    {
        throw new PendingStepException();
    }

    [Then(@"I should see all Books available with the total of ""(.*)"" results")]
    public void ThenIShouldSeeAllBooksAvailableWithTheTotalOfResults(string p0)
    {
        throw new PendingStepException();
    }

    [When(@"I locate book named ""(.*)""")]
    public void WhenILocateBookNamed(string p0)
    {
        throw new PendingStepException();
    }

    [Then(@"I should see the book price of ""(.*)"" and I can add it to the basket")]
    public void ThenIShouldSeeTheBookPriceOfAndICanAddItToTheBasket(string p0)
    {
        throw new PendingStepException();
    }

}
