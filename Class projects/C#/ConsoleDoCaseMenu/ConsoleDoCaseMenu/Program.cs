using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDoCaseMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Luces Preguntar = new Luces();
            Preguntar.LeerEvaluar();
            Console.ReadKey();
        }
    }
}
