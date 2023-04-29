namespace StructuralDesignPatterns.FlyWeight.Odev1;

public interface ITextFormat
{
    void AppyFormat(string text);
}

public class TextFormat : ITextFormat
{
    public TextFormat(string font, int size, ConsoleColor color)
    {
        Font = font;
        Size = size;
        Color = color;
    }

    public string Font { get; set; }
    public int Size { get; set; }
    public ConsoleColor Color { get; set; }

    public void AppyFormat(string text)
    {
        Console.WriteLine($"Metin: '{text}', Font: {Font}, Boyut: {Size}, Renk: {Color} ");
    }
}

public class TextFormatFactory
{
    private readonly Dictionary<string, TextFormat> _formatCache = new();

    public ITextFormat GetFormat(string font, int size, ConsoleColor color)
    {
        string key = $"{font}_{size}_{color}";

        if (!_formatCache.ContainsKey(key))
        {
            _formatCache[key] = new TextFormat(font, size, color);
        }

        return _formatCache[key];
    }
}
