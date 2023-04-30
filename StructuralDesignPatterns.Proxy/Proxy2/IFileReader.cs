namespace StructuralDesignPatterns.Proxy.Proxy2;

public interface IFileReader
{
    void ReadFile(string fileName);
}

public class RealFileReader : IFileReader
{
    public void ReadFile(string fileName)
    {
        Console.WriteLine($"Dosya okundu: {fileName}");
    }
}

public class SecureFileReader : IFileReader
{
    private RealFileReader _realFileReader;
    private string _userRole;

    public SecureFileReader(string userRole)
    {
        _userRole = userRole;
    }

    public void ReadFile(string fileName)
    {
        if(_userRole == "Admin")
        {
            if(_realFileReader == null)
            {
                _realFileReader = new RealFileReader();
            }

            _realFileReader.ReadFile(fileName);
        }
        else
        {
            Console.WriteLine("İşlem için yetkiniz yok!");
        }
    }
}
