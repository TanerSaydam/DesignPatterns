using CreationalDesignPatterns.Singleton.Odev1;

namespace CreationalDesignPatterns.Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Database database = Database.Instance; //instance türetme / örnek türetme
            //Database database1 = Database.Instance; //instance türetme / örnek türetme
            //Database database2 = Database.Instance; //instance türetme / örnek türetme
            //Database database3 = Database.Instance; //instance türetme / örnek türetme

            //Logger.Instance.Log("Bağlangıçta yapılan işlem tamamlandı!");
            //Logger.Instance.Log("Sonraki işlem tamamlandı");
            //Logger logger = Logger.Instance;

            //logger.Log("Yeni bir loglama yapıldı");

            ConfigurationManager configurationManager = ConfigurationManager.Instance;

            string apiKey = configurationManager.GetValue("apiKey");
            Console.WriteLine(apiKey);

            Console.WriteLine("Hello, World!");
        }
    }
}