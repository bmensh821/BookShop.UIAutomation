namespace BookTest.Configuration.Settings;

public class ChromeSettings
{
    public int CommandTimeout { get; set; } // seconds
    public string[] Arguments { get; set; } = Array.Empty<string>();
}
