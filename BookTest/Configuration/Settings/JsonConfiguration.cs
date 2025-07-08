using Newtonsoft.Json;

namespace BookTest.Configuration.Settings;

public class JsonConfiguration
{
    private readonly Dictionary<string, object> _sections;

    public JsonConfiguration(string fileName)
    {
        var fullPath = Path.Combine(AppContext.BaseDirectory, "Configuration", fileName);
        var json = File.ReadAllText(fullPath);
        _sections = JsonConvert.DeserializeObject<Dictionary<string, object>>(json)
                    ?? throw new Exception("Configuration file couldn't be parsed.");
    }

    public T GetSettings<T>(string sectionName)
    {
        if (_sections.TryGetValue(sectionName, out var sectionObj))
        {
            var json = JsonConvert.SerializeObject(sectionObj);
            return JsonConvert.DeserializeObject<T>(json);
        }

        throw new Exception($"Section '{sectionName}' not found in config.");
    }
}
