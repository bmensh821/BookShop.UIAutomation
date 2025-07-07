using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTest.Configuration.Settings;

public class BookTestConfiguration
{
    // Explicit static constructor to tell C# compiler 
    // not to mark type as beforefieldinit
    static BookTestConfiguration()
    {
        instance.Config = new JsonConfiguration($"{EnvironmentSettings.Current}.config.json");
    }

    private BookTestConfiguration()
    {
    }

    public static BookTestConfiguration Instance => instance;

    private static readonly BookTestConfiguration instance = new BookTestConfiguration();

    protected JsonConfiguration Config { get; set; }

    public EnvironmentSettings EnvironmentSettings => Config.GetSettings<EnvironmentSettings>("environmentSettings");

    public AtataSettings AtataSettings => Config.GetSettings<AtataSettings>(nameof(AtataSettings));

    public ChromeSettings ChromeSettings => Config.GetSettings<ChromeSettings>(nameof(ChromeSettings));

    public BookTestUrlSettings UrlSettings => Config.GetSettings<BookTestUrlSettings>(nameof(UrlSettings));

}
