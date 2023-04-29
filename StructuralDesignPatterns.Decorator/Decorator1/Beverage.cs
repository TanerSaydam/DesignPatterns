namespace StructuralDesignPatterns.Decorator.Decorator1;

public abstract class Beverage
{
    public abstract string Description { get; }
    public abstract double Cost();
}

public class Espresso : Beverage
{
    public override string Description => "Espresso";

    public override double Cost()
    {
        return 15.50;
    }
}

public abstract class BeverageDecorator: Beverage
{
    protected Beverage _beverage;

    public BeverageDecorator(Beverage beverage)
    {
        _beverage = beverage;
    }
}

public class Milk : BeverageDecorator
{
    public Milk(Beverage beverage) : base(beverage)
    {
    }

    public override string Description => _beverage.Description + ", Süt";

    public override double Cost()
    {
        return _beverage.Cost() + 0.50;
    }
}
