using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    public class Style
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Image Image { get; set; }
        public Style(string name, double price, Image image)
        {
            Name = name;
            Price = price;
            Image = image;
        }

        public override string ToString()
        {
           return $"{Name} ({Price:C})";
        }
    }
}
