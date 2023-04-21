namespace CreationalDesignPatterns.AbstractFactory.Models2;

internal class ModernKoltuk : IKoltuk
{
    public void BilgiVer()
    {
        Console.WriteLine("Modern koltuk üretiliyor...");
    }
}
