using System;
using System.Globalization;

namespace UsingGeneric.Entities
{
    class Product: IComparable
    {
        public string Name { get; private set; }
        public double Price { get; private set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"Name: {Name} - Price: R$ {Price.ToString("F2",CultureInfo.InvariantCulture)}";
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Product))
                throw new ArgumentException("Compare error: Argument is not a Product!");

            Product other = obj as Product;
            return Price.CompareTo(other.Price);
        }
    }
}
