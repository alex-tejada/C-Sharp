using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaPatDirRobotCo
{
    public class RobotCasero : Robot
    {
        public RobotCasero()
        {
            _disparador = new NoDisparar();
            _caminador = new CaminarNormal();
        }

    }
}
