using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDoWhileGato
{
    public class Contar
    {
        int conta, num;

        public void LeerEvaluar()
        {
            Console.WriteLine("Escribe un numero");
            num = int.Parse(Console.ReadLine());
            conta = 1;
            do
            {
                Console.WriteLine("GATO");
                conta++;
            }
            while (conta <= num);
            Console.WriteLine("Se ha impreso la palabra gato "+num+" veces");
        }
    }
}
