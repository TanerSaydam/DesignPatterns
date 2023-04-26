namespace StructuralDesignPatterns.Adapter.Adapter2;

public interface IDatabase
{
    void Connect();
    void ExecuteQuery(string query);
}

public class MySqlDatabase : IDatabase
{
    public void Connect()
    {
        Console.WriteLine("MySQL veritabına bağlandı!");
    }

    public void ExecuteQuery(string query)
    {
        Console.WriteLine($"MySql veritabanında {query} sorgusu çalıştırıldı!");
    }
}

public class SqlServer
{
    public void OpenConnection()
    {
        Console.WriteLine("SqlServer veritabına bağlandı!");
    }

    public void RunQuery(string query)
    {
        Console.WriteLine($"SqlServer veritabanında {query} sorgusu çalıştırıldı!");
    }
}

public class SqlServerAdapter : IDatabase
{
    private SqlServer _sqlServer;
    public SqlServerAdapter()
    {
        _sqlServer = new();
    }
    public void Connect()
    {
        _sqlServer.OpenConnection();
    }

    public void ExecuteQuery(string query)
    {
        _sqlServer.RunQuery(query);
    }
}
