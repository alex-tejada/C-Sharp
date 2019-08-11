using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaPatDisSC
{
    class RobotVigilante : Robot, IDisparable, ICaminable
    {
        public void Caminar()
        {
            Console.WriteLine("Robot Vigilante Caminando");
        }
        public void Disparar()
        {
            Console.WriteLine("Robot Vigilante Disparando");
        }
    }
}
