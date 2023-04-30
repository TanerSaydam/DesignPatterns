namespace StructuralDesignPatterns.Proxy.Odev1;

public interface IMessageSender
{
    void SendMessage(string message);
}

public class RealMessageSender : IMessageSender
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"Mesaj gönderildi: {message}");
    }
}

public class SecureMessageSender : IMessageSender
{
    private RealMessageSender _realMessageSender;
    private string _userRole;

    public SecureMessageSender(string userRole)
    {
        _userRole = userRole;
    }

    public void SendMessage(string message)
    {
        if(_userRole == "Admin")
        {
            if(_realMessageSender == null)
            {
                _realMessageSender = new RealMessageSender();
            }

            _realMessageSender.SendMessage(message);
        }
        else
        {
            Console.WriteLine("İşlem yapmaya yetkiniz yok!");
        }
    }
}
