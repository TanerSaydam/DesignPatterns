namespace StructuralDesignPatterns.Decorator.Decorator2;

public abstract class UIComponent
{
    public abstract void Display();
}

public class Button : UIComponent
{
    public override void Display()
    {
        Console.WriteLine("Buton gösterildi!");
    }
}

public abstract class UIComponentDecorator : UIComponent
{
    protected UIComponent _component;

    public UIComponentDecorator(UIComponent component)
    {
        _component = component;
    }

    public override void Display()
    {
        _component.Display();
    }
}

public class BorderDecoratoer : UIComponentDecorator
{
    public BorderDecoratoer(UIComponent component) : base(component)
    {
    }

    public override void Display()
    {
        base.Display();
        AddBorder();
    }

    private void AddBorder()
    {
        Console.WriteLine("Çizgi eklendi");
    }
}
