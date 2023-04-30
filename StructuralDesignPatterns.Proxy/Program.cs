using StructuralDesignPatterns.Proxy.Odev1;
using StructuralDesignPatterns.Proxy.Proxy1;
using StructuralDesignPatterns.Proxy.Proxy2;

namespace StructuralDesignPatterns.Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ISubject proxy = new Proxy1.Proxy();
            //proxy.Request();

            //IFileReader secureFileReader1 = new SecureFileReader("Admin");
            //secureFileReader1.ReadFile("Önemli Bilgiler 1");

            //IFileReader secureFileReader2 = new SecureFileReader("User");
            //secureFileReader2.ReadFile("Önemli Bilgiler 1");
            //Console.WriteLine("Hello, World!");

            IMessageSender secureMessageSender1 = new SecureMessageSender("Admin");
            secureMessageSender1.SendMessage("Merhaba, naber!");

            IMessageSender secureMessageSender2 = new SecureMessageSender("User");
            secureMessageSender2.SendMessage("Merhaba, naber!");
        }
    }
}