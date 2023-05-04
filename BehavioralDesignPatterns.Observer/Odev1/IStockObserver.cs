namespace BehavioralDesignPatterns.Observer.Odev1;

public interface IStockObserver
{
    void Update(string productName, int stock);
}

public interface IObservable
{
    void Register(IStockObserver observer);
    void UnRegister(IStockObserver observer);
    void Notify(string productName);
}

public class StockTracker : IObservable
{
    private List<IStockObserver> _stockObservers = new();
    private Dictionary<string, int> _stockData =new();
    public void Notify(string productName)
    {
        int stock = _stockData[productName];
        foreach (var observer in _stockObservers)
        {
            observer.Update(productName, stock);
        }
    }

    public void Register(IStockObserver observer)
    {
        _stockObservers.Add(observer);
    }

    public void UnRegister(IStockObserver observer)
    {
        _stockObservers.Remove(observer);
    }

    public void UpdateStock(string productName, int stock)
    {
        _stockData[productName] = stock;
        Notify(productName);
    }
}

public class Department : IStockObserver
{
    private string _name;

    public Department(string name)
    {
        _name = name;
    }

    public void Update(string productName, int stock)
    {
        Console.WriteLine($"{_name} Depatmanı: {productName} stok bilgisi {stock} birim olarak değiştirildi!");
    }
}
