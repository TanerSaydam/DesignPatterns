namespace BehavioralDesignPatterns.Strategy.Strategy1;

public interface IDrawStrategy
{
    void Draw();
}

public class DrawCircle : IDrawStrategy
{
    public void Draw()
    {
        Console.WriteLine("Bir yuvarlak çiziliyor.");
    }
}

public class DrawRectangle : IDrawStrategy
{
    public void Draw()
    {
        Console.WriteLine("Bir dikdörtgen çiziliyor.");
    }
}

public class DrawTriangle : IDrawStrategy
{
    public void Draw()
    {
        Console.WriteLine("Bir üçgen çiziliyor.");
    }
}


public class Shape
{
    private IDrawStrategy _strategy;

    public Shape(IDrawStrategy strategy)
    {
        _strategy = strategy;
    }

    public void SetDrawStrategy(IDrawStrategy strategy)
    {
        _strategy = strategy;
    }

    public void Draw()
    {
        _strategy.Draw();
    }
}