using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    public class Order
    {
        public Occasion Occasion { get; set; }
        public Style Style { get; set; }
        public bool Envelope { get; set; }
        public bool Stamp { get; set; }
        public bool AddMessage { get; set; }
        public string Message { get; set; }
        public double CalculateTotal()
        {
            double total = Style.Price;
            if (Envelope)
            {
                total += 0.25;
            }
            if (Stamp)
            {
                total += 0.50;
            }
            if (AddMessage)
            {
                total += 0.25;
            }
            return total;
        }
    }
}
