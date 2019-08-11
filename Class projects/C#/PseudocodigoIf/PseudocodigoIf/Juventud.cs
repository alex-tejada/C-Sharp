using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudocodigoIf
{
    public class Juventud
    {
        int edad;

        public void LeerPreguntar()
        {
            Console.WriteLine("Cual es tu edad?");
            edad = int.Parse(Console.ReadLine());
            if (edad >= 18)
            {
                Console.WriteLine("Eres mayor de EDAD");
            }
            else
            {
                Console.WriteLine("Eres menor de EDAD");
            }
            Console.WriteLine("Fin de Algoritmo");
        }
    }
}
