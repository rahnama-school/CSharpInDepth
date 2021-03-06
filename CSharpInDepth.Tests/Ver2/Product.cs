using System.Collections.Generic;

namespace CSharpInDepth.Tests.Ver2
{
    public class Product
    {
        private string name;

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        private decimal price;

        public decimal Price
        {
            get { return price; }
            private set { price = value; }
        }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public static List<Product> GetSampleProducts()
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("West Side Story", 9.99m));
            list.Add(new Product("Assasians", 14.99m));
            list.Add(new Product("Frogs", 13.99m));
            list.Add(new Product("Sweeney Todd", 10.99m));

            return list;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", name, price);
        }

    }
}