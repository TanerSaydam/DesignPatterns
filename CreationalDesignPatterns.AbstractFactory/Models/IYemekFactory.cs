namespace CreationalDesignPatterns.AbstractFactory.Models;

internal interface IYemekFactory
{
    public IAnaYemek YemekHazirla();
    public ISalata SalataHazirla();
}
