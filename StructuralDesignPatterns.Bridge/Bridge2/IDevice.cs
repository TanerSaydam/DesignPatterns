namespace StructuralDesignPatterns.Bridge.Brdige2;

public interface IDevice
{
    bool IsEnabled();
    void Enable();
    void Disable();
    int GetVolume();
    void SetVolume(int percent);
}

public class Televizyon : IDevice
{
    private bool _isEnabled;
    private int _volume;

    public void Disable() => _isEnabled = false;

    public void Enable() => _isEnabled = true;

    public int GetVolume() => _volume;

    public bool IsEnabled() => _isEnabled;

    public void SetVolume(int percent) => _volume  = percent;
}


public class Radio : IDevice
{
    private bool _isEnabled;
    private int _volume;

    public void Disable() => _isEnabled = false;

    public void Enable() => _isEnabled = true;

    public int GetVolume() => _volume;

    public bool IsEnabled() => _isEnabled;

    public void SetVolume(int percent) => _volume = percent;
}

public class UzakKontrol
{
    protected IDevice Device;
    public UzakKontrol(IDevice device)
    {
        Device = device;
    }

    public void TogglePower()
    {
        if (Device.IsEnabled())
            Device.Disable();
        else
            Device.Enable();
    }

    public void SesiArttir()
    {
        Device.SetVolume(Device.GetVolume() + 10);
    }

    public void SesiAzalt()
    {
        Device.SetVolume(Device.GetVolume() - 10);
    }
}