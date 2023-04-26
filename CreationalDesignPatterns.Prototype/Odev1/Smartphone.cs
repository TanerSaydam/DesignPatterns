namespace CreationalDesignPatterns.Prototype.Odev1;

public class Smartphone : ICloneable
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public string OperatingSystem { get; set; }
    public int StorageCapacity { get; set; }
    public object Clone()
    {
        return this.MemberwiseClone();
    }
}
