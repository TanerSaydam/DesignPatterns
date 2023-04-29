namespace StructuralDesignPatterns.Proxy.Proxy1;

public interface ISubject
{
    void Request();
}

public class RealSubject : ISubject
{
    public void Request()
    {
        Console.WriteLine("Gerçek nesne işlemi yapıldı!");
    }
}

public class Proxy : ISubject
{
    private RealSubject _realSubject;

    public void Request()
    {
        if(_realSubject == null )
        {
            _realSubject = new RealSubject();
        }

        Console.WriteLine("Proxy üzerinde işlem gerçekleştiriliyor...");
        _realSubject.Request(); 
    }
}
