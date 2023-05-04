namespace BehavioralDesignPatterns.Strategy.Strategy2;

public interface IPaymentStrategy
{
    void Pay(decimal amount);
}

public class CreditCartPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"{amount} ödemesi kredi kartı ile yapıldı!");
    }
}

public class PaypalPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"{amount} ödemesi paypal ile yapıldı!");
    }
}

public class CryptoPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"{amount} ödemesi kripto para ile yapıldı!");
    }
}

public class Checkout
{
    private IPaymentStrategy _strategy;

    public Checkout(IPaymentStrategy strategy)
    {
        _strategy = strategy;
    }

    public void SetPaymentStrategy(IPaymentStrategy strategy)
    {
        _strategy = strategy;
    }

    public void Pay(decimal amount)
    {
        _strategy.Pay(amount);
    }
}
