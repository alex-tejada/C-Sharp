using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFor
{
    public class Numeros
    {
        int conta, num;

        public void LeerContar()
        {
            Console.WriteLine("Escribe un numero");
            num = int.Parse(Console.ReadLine());
            for (conta = 0; conta <=num ; conta++)
            {
                Console.WriteLine("Mi valor es: " + conta);
            }
        }
    }
}
