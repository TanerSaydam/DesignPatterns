namespace CreationalDesignPatterns.Builder.Models2;

internal class ProductDirector
{
    public Product BuildProduct(string color, string size, string brand)
    {
        return new ProductBuilder()
            .SetColor(color)
            .SetSize(size)
            .SetBrand(brand)
            .Build();
    }
}
