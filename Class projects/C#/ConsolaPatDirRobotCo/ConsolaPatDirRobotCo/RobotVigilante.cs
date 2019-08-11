using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaPatDirRobotCo
{
    class RobotVigilante : Robot
    {
        public RobotVigilante()
        {
            _caminador = new CaminarNormal();
            _disparador = new DispararNormal();
        }
    }
}
