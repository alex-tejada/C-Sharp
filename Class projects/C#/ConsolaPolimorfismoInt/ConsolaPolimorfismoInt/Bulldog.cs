using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaPolimorfismoInt
{
    public class Bulldog : IPerro
    {
        public string Ladrar()
        {
            return "Bulldog Ladrando";
        }
        public string Dormir()
        {
            return "Bulldog Durmiendo";
        }
    }
}
