using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaPatDirRobotCo
{
    class Program
    {
        static void Main(string[] args)
        {
            RobotCasero rc = new RobotCasero();
            RobotMilitar rm = new RobotMilitar();
            RobotVigilante rv = new RobotVigilante();
            RobotJohnConnor rjc = new RobotJohnConnor();
            rc.Caminar();
            rc.Disparar();
            rm.Caminar();
            rm.Disparar();
            rv.Caminar();
            rv.Disparar();
            rjc.Caminar();
            rjc.Disparar();
            Console.ReadKey();
        }
    }
}
