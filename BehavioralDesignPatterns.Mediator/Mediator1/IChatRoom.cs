namespace BehavioralDesignPatterns.Mediator.Mediator1;

public interface IChatRoom
{
    void Register(User user);
    void Send(string from, string to, string message);
}

public abstract class User
{
    public string Name { get; private set; }
    public IChatRoom ChatRoom { get; set; }
    protected User(string name)
    {
        Name = name;
    }

    public void Send(string to, string message)
    {
        ChatRoom.Send(Name, to, message);
    }

    public abstract void Receive(string from, string message);
}

public class ChatRoom : IChatRoom
{
    private Dictionary<string, User> _users = new();
    public void Register(User user)
    {
        if (!_users.ContainsValue(user))
        {
            _users[user.Name] = user;
            user.ChatRoom = this;
        }
    }

    public void Send(string from, string to, string message)
    {
        if(_users.ContainsKey(from) && _users.ContainsKey(to))
        {
            User recepient = _users[to];
            recepient.Receive(from, message);
        }
    }
}

public class Participant : User
{
    public Participant(string name): base(name)
    {
        
    }
    public override void Receive(string from, string message)
    {
        Console.WriteLine($"{Name}'e {from}'dan mesaj geldi, mesaj: {message}");
    }
}
