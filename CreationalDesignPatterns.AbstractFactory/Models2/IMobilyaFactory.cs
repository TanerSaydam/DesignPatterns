namespace CreationalDesignPatterns.AbstractFactory.Models2;

internal interface IMobilyaFactory
{
    IKoltuk KoltukOlustur();
    IMasa MasaOlustur();
}
