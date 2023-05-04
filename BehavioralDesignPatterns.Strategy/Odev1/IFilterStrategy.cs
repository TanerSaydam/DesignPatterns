namespace BehavioralDesignPatterns.Strategy.Odev1;

public interface IFilterStrategy
{
    void ApplyFilter(string image);
}

public class BlackAndWhiteFilter : IFilterStrategy
{
    public void ApplyFilter(string image)
    {
        Console.WriteLine($"{image} resmine siyah beyaz filitre uygulandı!");
    }
}

public class SepiaFilter : IFilterStrategy
{
    public void ApplyFilter(string image)
    {
        Console.WriteLine($"{image} resmine sepia filitre uygulandı!");
    }
}

public class BrightnessFilter : IFilterStrategy
{
    public void ApplyFilter(string image)
    {
        Console.WriteLine($"{image} resmine ışık filitresi uygulandı!");
    }
}
public class ImageEditor
{
    private IFilterStrategy _filterStrategy;

    public ImageEditor(IFilterStrategy filterStrategy)
    {
        _filterStrategy = filterStrategy;
    }

    public void SetFilterStrategy(IFilterStrategy filterStrategy)
    {
        _filterStrategy = filterStrategy;
    }

    public void ApplyFilter(string image)
    {
        _filterStrategy.ApplyFilter(image);
    }
}

