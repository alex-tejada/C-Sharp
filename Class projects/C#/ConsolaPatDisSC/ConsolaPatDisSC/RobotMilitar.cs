using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaPatDisSC
{
    class RobotMilitar :Robot, IDisparable, ICaminable
    {
        public void Caminar()
        {
            Console.WriteLine("Robot Militar Caminar");
        }
        public void Disparar()
        {
            Console.WriteLine("Robot Militar Disparar");
        }
    }
}
