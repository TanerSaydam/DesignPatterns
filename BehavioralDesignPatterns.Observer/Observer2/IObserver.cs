namespace BehavioralDesignPatterns.Observer.Observer2;

public interface IObserver
{
    void Update(float sicaklık, float nem);
}

public interface IObservable
{
    void Register(IObserver observer);
    void UnRegister(IObserver observer);
    void Notify();
}

public class HavaIstasyonu : IObservable
{
    private float _sicaklik;
    private float _nem;

    private List<IObserver> _observers = new();
    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_sicaklik, _nem);
        }
    }

    public void Register(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void UnRegister(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void OlcumleriAyarla(float sicaklik, float nem)
    {
        _sicaklik = sicaklik;
        _nem = nem;
        Notify();
    }

    public float GetSicaklik() => _sicaklik;
    public float GetNem() => _nem;
}

public class MobileApp : IObserver
{
    public void Update(float sicaklık, float nem)
    {
        Console.WriteLine($"Mobile App: Sıcaklık: {sicaklık}, Nem: {nem}");
    }
}

public class WebsiteApp : IObserver
{
    public void Update(float sicaklık, float nem)
    {
        Console.WriteLine($"Website App: Sıcaklık: {sicaklık}, Nem: {nem}");
    }
}

public class LCDApp : IObserver
{
    public void Update(float sicaklık, float nem)
    {
        Console.WriteLine($"LCD App: Sıcaklık: {sicaklık}, Nem: {nem}");
    }
}
