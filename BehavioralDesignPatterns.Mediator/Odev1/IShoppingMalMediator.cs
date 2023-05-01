namespace BehavioralDesignPatterns.Mediator.Odev1;

public interface IShoppingMalMediator
{
    void RegisterDiscount(string storeName, string discount);
    void RegisterEvent(string storeName, string eventIntfo);
    List<string> GetDiscount();
    List<string> GetEvents();
}

public class ShoppingMalMediator : IShoppingMalMediator
{
    private Dictionary<string, string> _discounts = new();
    private Dictionary<string, string> _events = new();
    
    public List<string> GetDiscount()
    {
        List<string> discountList = new List<string>();
        foreach (var discount in _discounts)
        {
            discountList.Add($"{discount.Key}: {discount.Value}");
        }

        return discountList;
    }

    public List<string> GetEvents()
    {
        List<string> eventList = new();
        foreach (var e in _events)
        {
            eventList.Add($"{e.Key}: {e.Value}");
        }

        return eventList;
    }

    public void RegisterDiscount(string storeName, string discount)
    {
        _discounts[storeName] = discount;
    }

    public void RegisterEvent(string storeName, string eventIntfo)
    {
        _events[storeName] = eventIntfo;
    }
}

public abstract class Colleague
{
    protected IShoppingMalMediator _mediator;

    protected Colleague(IShoppingMalMediator mediator)
    {
        _mediator = mediator;
    }
}

public class Store: Colleague
{
    public string Name { get; private set; }
    public Store(string name, IShoppingMalMediator mediator): base(mediator)
    {
        Name = name;
    }

    public void AnnounceDiscount(string discount)
    {
        _mediator.RegisterDiscount(Name, discount);
    }

    public void AnnounceEvent(string eventInfo)
    {
        _mediator.RegisterEvent(Name, eventInfo);
    }
}

public class Visitor : Colleague
{
    public string Name { get; private set; }
    public Visitor(string name, IShoppingMalMediator mediator) : base(mediator)
    {
        Name = name;
    }

    public void CheckDiscounts()
    {
        Console.WriteLine($"{Name} indirimleri kontrol ediyor");

        List<string> discounts = _mediator.GetDiscount();

        foreach (var discount in discounts)
        {
            Console.WriteLine(discount);
        }
    }

    public void CheckEvents()
    {
        Console.WriteLine($"{Name} etkinlikleri kontrol ediyor");

        List<string> events = _mediator.GetEvents();

        foreach (var e in events)
        {
            Console.WriteLine(e);
        }
    }
}
