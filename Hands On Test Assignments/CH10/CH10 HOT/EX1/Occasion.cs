using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    public class Occasion
    {
        public string Name { get; set; }
        public List<Style> Styles { get; set; }
        public Occasion(string name)
        {
            Name = name;
            Styles = new List<Style>();
        }
    }
}
