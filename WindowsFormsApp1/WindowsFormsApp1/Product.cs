using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp1
{
    class Product
    {
        public double Price { get; set; }
        public string Name { get; set; }

        public int InStock { get; set; }

        public Product(string name, double price, int inStock)
        {
            Name = name;
            Price = price;
            InStock = inStock;
        }

        public override string ToString()
        {
            return Name + ",price: " + Price;
        }
    }
}
