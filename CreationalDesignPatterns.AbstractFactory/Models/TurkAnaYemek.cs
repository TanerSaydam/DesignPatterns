namespace CreationalDesignPatterns.AbstractFactory.Models;

internal class TurkAnaYemek : IAnaYemek
{
    public void Hazirla()
    {
        Console.WriteLine("Türk ana yemeği hazırlanıyor...");
    }
}
