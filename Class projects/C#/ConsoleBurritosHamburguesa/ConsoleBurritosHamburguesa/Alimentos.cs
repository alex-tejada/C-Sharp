using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBurritosHamburguesa
{
    public class Alimentos
    {
        string clave, ingredientes;
        int cantidad;
        double precio, importe;

        public void RegistrarAlimentos()
        {
            Console.WriteLine("Dame la clave del alimento");
            clave = Console.ReadLine();
            Console.WriteLine("Dame los ingredientes");
            ingredientes = Console.ReadLine();
            Console.WriteLine("Dame la cantidad");
            cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine("Dame el precio del alimento");
            precio = double.Parse(Console.ReadLine());
            

        }
        public void MostrarAlimentos()
        {
            Console.WriteLine("La clave del producto es: " + clave);
            Console.WriteLine("Los ingredientes son: " + ingredientes);
            Console.WriteLine("La cantidad es: " + cantidad);
            Console.WriteLine("El precio del alimento es: {0:C}",precio);
            Console.WriteLine("");
        }
        public void CalcularImporte()
        {
            importe = precio * cantidad;
        }
        public void MostrarImporte()
        {
            Console.WriteLine("El importe total es: {0:C}",importe);
        }
    }
}
