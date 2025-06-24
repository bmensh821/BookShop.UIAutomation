using Reqnroll;
using Atata;

namespace BookTestRunner;

[Binding]
public class TestHooks
{
    [BeforeScenario]
    public void SetUp()
    {
        AtataContext.Configure()
            .UseChrome()
            .UseNUnitTestName()
            .LogConsumers.AddNUnitTestContext()
            .Build();
    }

    [AfterScenario]
    public void TearDown()
    {
        AtataContext.Current?.Dispose();
    }
}
