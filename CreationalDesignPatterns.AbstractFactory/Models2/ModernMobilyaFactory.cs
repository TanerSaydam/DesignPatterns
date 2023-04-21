namespace CreationalDesignPatterns.AbstractFactory.Models2;

internal class ModernMobilyaFactory : IMobilyaFactory
{
    public IKoltuk KoltukOlustur()
    {
        return new ModernKoltuk();
    }

    public IMasa MasaOlustur()
    {
        return new ModernMasa();
    }
}
