using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Builder.Models2
{
    internal class ProductBuilder
    {
        private Product product;

        public ProductBuilder()
        {
            product = new Product();
        }

        public ProductBuilder SetColor(string color)
        {
            product.Color = color;
            return this;
        }

        public ProductBuilder SetSize(string size)
        {
            product.Size = size;
            return this;
        }

        public ProductBuilder SetBrand(string brand)
        {
            product.Brand = brand;
            return this;
        }

        public Product Build()
        {
            return product;
        }
    }
}
