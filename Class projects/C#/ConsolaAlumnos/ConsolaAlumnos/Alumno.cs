using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaAlumnos
{
    public class Alumno
    {
        string nombre, apellido, grupo;

        public void RegistrarNombre()
        {
            Console.WriteLine("Dame el nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Dame el apellido");
            apellido = Console.ReadLine();
            Console.WriteLine("Dame el grupo");
            grupo = Console.ReadLine();
        }
        public void MostrarNombre()
        {
            Console.WriteLine("El nombre del alumno es: " + nombre);
            Console.WriteLine("El apellido del alumno es: " + apellido);
            Console.WriteLine("El grupo del alumno es: " + grupo);
        }
    }
}
