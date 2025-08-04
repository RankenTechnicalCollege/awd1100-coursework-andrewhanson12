using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Superhero
    {
        public string Name { get; set; }
        public string Likes { get; set; }
        public string Dislikes { get; set; }
        public string Superpower { get; set; }
        public string Biography { get; set; }
        public Image Image { get; set; }
        public string Url { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
