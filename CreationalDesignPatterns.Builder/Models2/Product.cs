namespace CreationalDesignPatterns.Builder.Models2;

internal class Product
{
    public Product()
    {
        Color = "Kırmızı";
        Size = "M";
        Brand = "Nike";
    }
    public string Color { get; set; }
    public string Size { get; set; }
    public string Brand { get; set; }
}
