namespace CreationalDesignPatterns.AbstractFactory.Models2
{
    internal class KlasikMobilyaFactory : IMobilyaFactory
    {
        public IKoltuk KoltukOlustur()
        {
            return new KlasikKoltuk();
        }

        public IMasa MasaOlustur()
        {
            return new KlasikMasa();
        }
    }
}
