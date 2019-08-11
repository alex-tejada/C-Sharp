using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaProductosAbarrotes
{
    public class Productos
    {
        string codigo;
        int cantidad;
        double precio, importe, descuento, imporpor, importetot;

        public void RegistrarProducto()
        {
            Console.WriteLine("Dame el codigo del producto");
            codigo =  Console.ReadLine();
            Console.WriteLine("Dame la cantidad de producto");
            cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine("Dame el precio del producto");
            precio = double.Parse(Console.ReadLine());
            Console.WriteLine("Dame el descuento");
            descuento = double.Parse(Console.ReadLine());
            importe = precio * cantidad;
            imporpor = (importe * descuento) / 100;
            importetot = importe - imporpor;

        }
        public void MostrarProducto()
        {
            Console.WriteLine("El codigo del producto es: " +codigo);
            Console.WriteLine("La cantidad del producto es: " + cantidad);
            Console.WriteLine("El precio del producto es: " + precio);
            Console.WriteLine("El descuento del producto es: " + descuento);
            Console.WriteLine("El importe del producto es: {0:C}",importe);
            Console.WriteLine("El importe a descontar del producto es: {0:C}",imporpor);
            Console.WriteLine("El importe total es: {0:C}",importetot);

        }
    }
}
