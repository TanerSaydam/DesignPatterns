namespace CreationalDesignPatterns.AbstractFactory.Models;

internal class ItalyanSalata : ISalata
{
    public void Hazirla()
    {
        Console.WriteLine("İtalyan salata hazırlanıyor...");
    }
}
