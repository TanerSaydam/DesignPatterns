namespace CreationalDesignPatterns.AbstractFactory.Models2;

internal class KlasikKoltuk : IKoltuk
{
    public void BilgiVer()
    {
        Console.WriteLine("Klasik koltuk üretiliyor...");
    }
}
