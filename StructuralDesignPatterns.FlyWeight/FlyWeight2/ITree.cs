namespace StructuralDesignPatterns.FlyWeight.FlyWeight2;

public interface ITree
{
    void Draw(int x, int y);
}

public class Tree : ITree
{
    private readonly string _treeType;

    public Tree(string treeType)
    {
        _treeType = treeType;
    }

    public void Draw(int x, int y)
    {
        Console.WriteLine($"Ağaç türü {_treeType}, konum ({x}, {y})");
    }
}

public class TreeFactory
{
    private readonly Dictionary<string, ITree> _treeCache = new();

    public ITree GetTree(string treeType)
    {
        if (!_treeCache.ContainsKey(treeType))
        {
            _treeCache[treeType] = new Tree(treeType);
        }

        return _treeCache[treeType];
    }
}

public class Forest
{
    private readonly List<(ITree tree, int x, int y)> _trees = new();
    private readonly TreeFactory _treeFactory = new();

    public void PlantTree(int x, int y, string treeType)
    {
        ITree tree = _treeFactory.GetTree(treeType);
        _trees.Add((tree, x, y));
    }

    public void Draw()
    {
        foreach (var (tree,x,y) in _trees)
        {
            tree.Draw(x, y);
        }
    }
}
