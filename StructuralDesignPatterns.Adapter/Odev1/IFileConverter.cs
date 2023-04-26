namespace StructuralDesignPatterns.Adapter.Odev1;

public interface IFileConverter
{
    string Convert(string value);
}

public class XMLConvert : IFileConverter
{
    public string Convert(string value)
    {
        Console.WriteLine("XML formatlama işlemi tamamlandı!");
        return "convertedXML";
    }
}

public class JSONConvert
{
    public string Transform(string value)
    {
        Console.WriteLine("JSON formatlama işlemi tamamlandı!");
        return "convertedJSON";
    }
}

public class JSONConvertAdapter : IFileConverter
{
    private JSONConvert _jsonConvert;

    public JSONConvertAdapter()
    {
        _jsonConvert = new();
    }

    public string Convert(string value)
    {
        return _jsonConvert.Transform(value);
    }
}

