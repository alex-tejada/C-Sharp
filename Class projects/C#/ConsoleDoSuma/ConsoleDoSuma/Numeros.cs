using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDoSuma
{
    public class Numeros
    {
        int num, suma, i;
        public void LeerCalcular()
        {
            Console.WriteLine("Escribe un numero: ");
            num = int.Parse(Console.ReadLine());
            suma = 0; i = 1;
            do
            {
                suma = suma + i;
                i += 1;
            } while (i<=num);
            Console.WriteLine("La suma es: "+suma);
        }
    }
}
