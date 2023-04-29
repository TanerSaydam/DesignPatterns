namespace StructuralDesignPatterns.Decorator.Odev1;

public interface IService
{
    void Execute();
}

public class BasicService : IService
{
    public void Execute()
    {
        Console.WriteLine("Basic service executed.");
    }
}

public abstract class ServiceDecorator : IService
{
    protected IService _service;
    public ServiceDecorator(IService service)
    {
        _service = service;
    }

    public abstract void Execute();
}

public class AuthorizationDecorator : ServiceDecorator
{
    public AuthorizationDecorator(IService service) : base(service)
    {
    }

    public override void Execute()
    {
        if (CheckAtuhorization())
        {
            _service.Execute();
        }
        else
        {
            Console.WriteLine("Buraya erişmeye yetkiniz yok!");
        }
    }

    private bool CheckAtuhorization()
    {
        //işlemler
        return true;
    }
}
