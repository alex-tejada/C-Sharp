using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoAbstraccion
{
    public class Chihuahua : Perro
    {
        public override string Ladrar()
        {
            return "Perro Chihuahua Ladrando";
        }
        public override string Dormir()
        {
            return "Perro Chihuahua Durmiendo";
        }
    }
}
