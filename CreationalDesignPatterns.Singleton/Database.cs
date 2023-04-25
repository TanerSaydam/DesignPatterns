namespace CreationalDesignPatterns.Singleton;

public class Database
{
    private static Database _instance;
    private static readonly object _lock = new object();
    private Database()
    {
        Console.WriteLine("Database Instance oluşturuldu!");
    }

    public static Database Instance
    {
        get
        {
            if(_instance == null)
            {
                lock(_lock)
                {
                    if(_instance == null)
                    {
                        _instance = new Database();
                    }
                }
            }

            return _instance;
        }
    }
}
