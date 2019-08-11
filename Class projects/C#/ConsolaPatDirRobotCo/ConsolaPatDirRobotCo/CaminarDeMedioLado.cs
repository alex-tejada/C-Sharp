using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaPatDirRobotCo
{
    public class CaminarDeMedioLado : ICaminarBehavior
    {
        public void Caminar()
        {
            Console.WriteLine("Caminar como cangrejo");
        }
    }
}
