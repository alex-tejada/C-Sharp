using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaPatDisSC
{
    class RobotDetectorJC : Robot, IDisparable
    {
        public void Disparar()
        {
            Console.WriteLine("Terminator disparando");
        }
    }
}
