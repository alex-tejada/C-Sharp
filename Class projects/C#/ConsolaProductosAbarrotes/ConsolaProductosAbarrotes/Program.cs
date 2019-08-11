using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaProductosAbarrotes
{
    class Program
    {
        static void Main(string[] args)
        {
            Productos Abarrotes = new Productos();
            Abarrotes.RegistrarProducto();
            Abarrotes.MostrarProducto();
            Console.ReadKey();
        }
    }


}
