namespace CreationalDesignPatterns.AbstractFactory.Models;

internal class TurkSalata : ISalata
{
    public void Hazirla()
    {
        Console.WriteLine("Türk salatası hazırlanıyor...");
    }
}
