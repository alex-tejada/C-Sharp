using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaPatDirRobotCo
{
    public abstract class Robot
    {
        protected ICaminarBehavior _caminador;
        protected IDisparaBehaviorr _disparador;

        public Robot()
        {

        }
        public void Caminar()
        {
            _caminador.Caminar();
        }
        public void Disparar()
        {
            _disparador.Disparar();
        }
    }
}
