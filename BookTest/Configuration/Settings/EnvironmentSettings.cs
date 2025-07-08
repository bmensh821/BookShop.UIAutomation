namespace BookTest.Configuration.Settings;

public class EnvironmentSettings
{
    public static string Current =>
        Environment.GetEnvironmentVariable("TEST_ENV")?.ToLowerInvariant() ?? "dev";
}
