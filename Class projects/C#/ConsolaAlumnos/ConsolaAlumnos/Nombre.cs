using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaAlumnos
{
    class Nombre
    {
        static void Main(string[] args)
        {
            Alumno al = new Alumno();
            al.RegistrarNombre();
            al.MostrarNombre();
            Console.ReadKey();
        }
    }
}
