using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Coin
    {
        public double Diameter { get; }
        public double Weight { get; }

        public Coin(double diameter, double weight)
        {
            Diameter = diameter;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"Diametur: {Diameter} sm, Teglo: {Weight} gr";
        }
    }
}
