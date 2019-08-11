using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaPatDisSC
{
    class RobotCasero : Robot, ICaminable
    {
        public void Caminar()
        {
            Console.WriteLine("Robot Casero Caminando");
        }
    }
}
