using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDoCaseMenu
{
    public class Luces
    {
        int eleccion;
        public void LeerEvaluar()
        {
            do
            {
                Console.WriteLine("==========================");
                Console.WriteLine("=MENU SEMAFORO=");
                Console.WriteLine("1 para elegir Color Verde");
                Console.WriteLine("2 para elegir Color Amarillo");
                Console.WriteLine("3 para elegir Color Rojo");
                Console.WriteLine("4 cerrar el Semaforo");
                Console.WriteLine("5 para salir");
                Console.WriteLine("==========================");
                Console.WriteLine("");
                Console.Write("Opcion: ");
                eleccion = int.Parse(Console.ReadLine());
                switch (eleccion)
                {
                    case 1:
                        Console.WriteLine("Se eligio el color verde, puede avanzar");
                    break;
                    case 2:
                        Console.WriteLine("Se eligio el color amarillo, puede avanzar con precaucion");
                    break;
                    case 3:
                        Console.WriteLine("Se eligio el color rojo,alto total");
                    break;
                    case 4:
                        Console.WriteLine("Se cerro el semaforo");
                    break;
                    case 5:
                        Console.WriteLine("Salir del menu");
                    break;
                    default:
                        Console.WriteLine("Opcion invalida");
                    break;
                }

            } while (eleccion != 5);
            Console.WriteLine("Presione cualquier tecla para salir")
        }
    }
}
