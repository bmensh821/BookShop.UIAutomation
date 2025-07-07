using Atata;
namespace BookTest.UI;

public class UITestContext : TestContext
{
    public static void GlobalOneTimeSetUp()
    {
        AtataContext.GlobalConfiguration
        .UseDefaultControlVisibility(Visibility.Visible)
        .UseBaseRetryTimeout(TimeSpan.FromSeconds(Config.AtataSettings.BaseRetryTimeout))
        .UseCulture("en-us")
        .UseArtifactsPathTemplate("Logs")
        .LogConsumers.AddNUnitTestContext()
        .UseChrome()
            .WithArguments(Config.ChromeSettings.Arguments.ToArray())
            .WithCommandTimeout(TimeSpan.FromSeconds(Config.ChromeSettings.CommandTimeout));

        AtataContext.GlobalConfiguration.AutoSetUpDriverToUse();
    }

    public static AtataContext StartDriver(string baseUrl)
    {
        return AtataContext.Configure().
            UseBaseUrl(baseUrl).
            Build();
    }

    public static AtataContext StartDriver() => StartDriver(Config.UrlSettings.BaseUrl);

    public static void StopDriver() => AtataContext.Current?.Dispose();

    public static void StopDriver(AtataContext context) => context.Dispose();

    public static TPage OpenInNextWindow<TPage>()
        where TPage : Page<TPage>
    {
        AtataContext.Current.Driver.AsScriptExecutor().ExecuteScript("window.open()");

        return Go.ToNextWindow<TPage>();
    }
}
