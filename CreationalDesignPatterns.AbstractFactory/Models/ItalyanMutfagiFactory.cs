namespace CreationalDesignPatterns.AbstractFactory.Models;

internal class ItalyanMutfagiFactory : IYemekFactory
{
    public ISalata SalataHazirla()
    {
        return new ItalyanSalata();
    }

    public IAnaYemek YemekHazirla()
    {
        return new ItalyanAnaYemek();
    }
}
