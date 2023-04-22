namespace CreationalDesignPatterns.Builder;

public class Car
{
    public Car()
    {
        Color = "Siyah";
        EnginePower = 100;
        Interior = "Deri Döşeme";           
    }
    public string Color { get; set; }
    public int EnginePower { get; set; }
    public string Interior { get; set; }
}
