namespace BehavioralDesignPatterns.Observer.Observer1;

public interface IObserver
{
    void Update(string message);
}

public interface IObservable
{
    void Register(IObserver observer);
    void Unregister(IObserver observer);
    void Notify();
}

public class Observable : IObservable
{
    private List<IObserver> _observers = new();
    private string _message;
    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_message);
        }
    }

    public void Register(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Unregister(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void SendMessage(string message)
    {
        _message = message;
        Notify();
    }
}

public class Observer : IObserver
{
    private string _name;

    public Observer(string name)
    {
        _name = name;
    }

    public void Update(string message)
    {
        Console.WriteLine($"{_name} kişisinden şu mesaj geldi: {message}");
    }
}
