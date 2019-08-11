using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaPatDirRobotCo
{
    public class NoCaminar : ICaminarBehavior
    {
        public void Caminar()
        {
            Console.WriteLine("No Caminar");
        }
    }
}
