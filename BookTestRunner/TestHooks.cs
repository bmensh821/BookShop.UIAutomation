using BookTest.UI;
using Reqnroll;

namespace BookTestRunner;

[Binding]
public sealed class TestHooks
{
    [BeforeTestRun]
    public static void SetUpTestRun()
    {
        UITestContext.GlobalOneTimeSetUp();
    }

    [BeforeScenario]
    public static void SetUpScenario()
    {
        UITestContext.StartDriver();
    }

    [AfterScenario]
    public static void TearDownScenario()
    {
        UITestContext.StopDriver();
    }
}
