namespace CreationalDesignPatterns.Singleton;

public class Logger
{
    private static Logger _instance;
    private static readonly object _lock = new object();
    private readonly string _logFilePath;

    private Logger()
    {
        _logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.txt");
    }

    public static Logger Instance
    {
        get
        {
            if(_instance == null)
            {
                lock(_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Logger();
                    }
                }
            }

            return _instance;
        }
    }

    public void Log(string message)
    {
        using (var streamWriter = new StreamWriter(_logFilePath, true))
        {
            streamWriter.WriteLine($"{DateTime.Now}: {message}");
        }
    }
}
