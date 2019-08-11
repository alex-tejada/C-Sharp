using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaPatDirRobotCo
{
    public class RobotJohnConnor : Robot
    {
        public RobotJohnConnor()
        {
            _disparador = new DispararAmetralladora();
            _caminador = new NoCaminar();
        }
    }
}
