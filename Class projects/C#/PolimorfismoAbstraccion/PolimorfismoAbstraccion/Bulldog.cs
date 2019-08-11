using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoAbstraccion
{
    public class Bulldog : Perro
    {
        public override string Ladrar()
        {
            return "Perro Bulldog Ladrando";
        }
        public override string Dormir()
        {
            return "Perro Bulldog Durmiendo";
        }
    }
}
