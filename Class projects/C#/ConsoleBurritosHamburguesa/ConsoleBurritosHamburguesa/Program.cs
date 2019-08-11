using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBurritosHamburguesa
{
    public class Program
    {
        static void Main(string[] args)
        {
            Alimentos burrito = new Alimentos();
            burrito.RegistrarAlimentos();
            burrito.MostrarAlimentos();
            burrito.CalcularImporte();
            burrito.MostrarImporte();

            Alimentos hamburguesa = new Alimentos();
            hamburguesa.RegistrarAlimentos();
            hamburguesa.MostrarAlimentos();
            hamburguesa.CalcularImporte();
            hamburguesa.MostrarImporte();

            Console.ReadKey();
        }
    }
}
