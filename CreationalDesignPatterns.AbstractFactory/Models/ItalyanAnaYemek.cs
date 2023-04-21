namespace CreationalDesignPatterns.AbstractFactory.Models;

internal class ItalyanAnaYemek : IAnaYemek
{
    public void Hazirla()
    {
        Console.WriteLine("İtalyan ana yemeği hazırlanıyor...");
    }
}
