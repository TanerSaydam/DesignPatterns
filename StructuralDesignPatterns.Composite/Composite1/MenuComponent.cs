namespace StructuralDesignPatterns.Composite.Composite1;

public abstract class MenuComponent
{
    public abstract void Print();
    public virtual void Add(MenuComponent component)
    {
        throw new NotImplementedException();
    }

    public virtual void Remove(MenuComponent component)
    {
        throw new NotImplementedException ();
    }
}

public class MenuItem : MenuComponent
{
    private readonly string _name;
    private readonly double _price;

    public MenuItem(string name, double price)
    {
        _name = name;
        _price = price;
    }

    public override void Print()
    {
        Console.WriteLine($"- {_name}: ₺{_price}");
    }
}

public class Menu : MenuComponent
{
    private readonly List<MenuComponent> _menuComponents = new List<MenuComponent>();
    private readonly string _name;

    public Menu(string name)
    {
        _name = name;
    }

    public override void Print()
    {
        Console.WriteLine($"{_name}:");
        foreach (MenuComponent menuComponent in _menuComponents)
        {
            menuComponent.Print();
        }
    }

    public override void Add(MenuComponent component)
    {
        _menuComponents.Add(component);
    }

    public override void Remove(MenuComponent component)
    {
        _menuComponents.Remove(component);
    }
}
