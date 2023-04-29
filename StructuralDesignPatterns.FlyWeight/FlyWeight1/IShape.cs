namespace StructuralDesignPatterns.FlyWeight.FlyWeight1;

public interface IShape
{
    void Draw(int x, int y);
}

public class Line : IShape
{
    public void Draw(int x, int y)
    {
        Console.WriteLine($"Çizgi çizildi: ({x}, {y})");
    }
}

public class Circle : IShape
{
    public void Draw(int x, int y)
    {
        Console.WriteLine($"Daire çizildi: ({x}, {y})");
    }
}

public class ShapeFactory
{
    private Dictionary<string, IShape> _shapes = new();

    public IShape GetShape(string shapeType)
    {
        if (!_shapes.ContainsKey(shapeType))
        {
            switch (shapeType)
            {
                case "line":
                    _shapes.Add("line", new Line());
                    break;
                case "circle":
                    _shapes.Add("circle", new Circle());
                    break;
            }
        }

        return _shapes[shapeType];
    }
}
