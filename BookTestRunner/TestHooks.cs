using Reqnroll;
using Atata;

namespace BookTestRunner;

[Binding]
public class TestHooks
{
    [BeforeScenario]
    public void SetUp()
    {
        var env = Environment.GetEnvironmentVariable("TEST_ENV") ?? "dev";
        var configFile = Path.Combine("Configuration", $"{env}.json");

        AtataContext.GlobalConfiguration
            .ApplyJsonConfig(configFile)
            .UseCulture("en-US")
            .UseBaseRetryTimeout(TimeSpan.FromSeconds(10))
            .UseChrome()
            .UseNUnitTestName();
        AtataContext.GlobalConfiguration.LogConsumers.AddNUnitTestContext();
        AtataContext.GlobalConfiguration.Build();

    }

    [AfterScenario]
    public void TearDown()
    {
        AtataContext.Current?.Dispose();
    }
}
