using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaPatDisSC
{
    class Program
    {
        static void Main(string[] args)
        {
            RobotCasero rc= new RobotCasero();
            RobotMilitar rm = new RobotMilitar();
            RobotVigilante rv = new RobotVigilante();
            RobotDetectorJC rdjc = new RobotDetectorJC();

            rc.Caminar();
            rm.Caminar();
            rm.Disparar();
            rv.Caminar();
            rv.Disparar();
            rdjc.Disparar();

            Console.ReadKey();
        }
    }
}
