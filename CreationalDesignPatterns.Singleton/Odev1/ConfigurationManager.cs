namespace CreationalDesignPatterns.Singleton.Odev1;

public sealed class ConfigurationManager
{
    private static ConfigurationManager _instance;
    private Dictionary<string, string> _settings;
    private static object _lock = new object();
    private ConfigurationManager()
    {
        _settings = new Dictionary<string, string>();
        _settings.Add("ApiKey", "12345");
        _settings.Add("ApiUrl", "https://wwww.tanersaydam.net");
        _settings.Add("Timeout", "30");
    }

    public static ConfigurationManager Instance
    {
        get
        {
            if(_instance == null)
            {
                lock(_lock)
                {
                    if(_instance == null)
                    {
                        _instance = new ConfigurationManager();
                    }
                }                   
            }
            return _instance;
        }
    }

    public string GetValue(string key)
    {
        if(_settings.TryGetValue(key, out string value))
        {
            return value;
        }
        else
        {
            return null;
        }
    }
}
