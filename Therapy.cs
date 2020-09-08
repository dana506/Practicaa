using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicaa
{
    public class Therapy
    {

        public string TherapyName { get; set; }
        public double Prices { get; set; }
        public Therapy(string therapy_name, double prices)
        {
            this.TherapyName = therapy_name;
            this.Prices = prices;
        }
    }
}

