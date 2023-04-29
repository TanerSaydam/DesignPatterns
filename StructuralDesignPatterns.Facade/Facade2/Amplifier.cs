namespace StructuralDesignPatterns.Facade.Facade2;

public class Amplifier
{
    public void On() => Console.WriteLine("Amplifier açıldı.");
    public void Off() => Console.WriteLine("Amplifier kapandı.");
    public void SetVolume(int value) => Console.WriteLine($"Amplifier ses seviyesi: {value}");
}

public class DvdPlayer
{
    public void On() => Console.WriteLine("DvdPlayer açıldı.");
    public void Off() => Console.WriteLine("DvdPlayer kapanndı.");
    public void Stop() => Console.WriteLine("DvdPlayer duraklatıldı.");
    public void Enject() => Console.WriteLine("Dvd çıkartıldı.");
    public void Play(string movie) => Console.WriteLine($"DvdPlayer oynatılıyor:  {movie}");
}

public class Projector
{
    public void On() => Console.WriteLine("Projector açıldı.");
    public void Off() => Console.WriteLine("Projector kapandı.");
    public void WideScreenMode() => Console.WriteLine("Projector geniş ekrana modu.");
}

public class HomeTheaterFacade
{
    private readonly Amplifier _amplifier;
    private readonly DvdPlayer _dvdPlayer;
    private readonly Projector _projector;
    public HomeTheaterFacade(Amplifier amplifier, DvdPlayer dvdPlayer, Projector projector)
    {
        _amplifier = amplifier;
        _dvdPlayer = dvdPlayer;
        _projector = projector;
    }

    public void WatchMovie(string movie)
    {
        Console.WriteLine("Ev sineme sistmei hazırlanıyor...");
        _amplifier.On();
        _amplifier.SetVolume(10);
        _dvdPlayer.On();
        _dvdPlayer.Play(movie);
        _projector.On();
        _projector.WideScreenMode();
    }

    public void EndMovie()
    {
        Console.WriteLine("Ev sinema sistemi kapatılıyor...");
        _amplifier.Off();
        _dvdPlayer.Stop();
        _dvdPlayer.Enject();
        _dvdPlayer.Off();
        _projector.Off();
    }
}
