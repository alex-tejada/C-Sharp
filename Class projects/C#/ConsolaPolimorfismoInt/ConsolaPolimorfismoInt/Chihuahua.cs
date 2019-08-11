using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaPolimorfismoInt
{
    public class Chihuahua : IPerro
    {
        public string Ladrar()
        {
            return "Chihuahua Ladrando";
        }
        public string Dormir()
        {
            return "Chihuahua Durmiendo";
        }
    }
}
