namespace CreationalDesignPatterns.AbstractFactory.Models;

internal class TurkMutfagiFactory : IYemekFactory
{
    public ISalata SalataHazirla()
    {
        return new TurkSalata();
    }

    public IAnaYemek YemekHazirla()
    {
        return new TurkAnaYemek();
    }
}
