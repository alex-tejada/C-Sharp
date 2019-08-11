using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudocodigoSwitch
{
    public class Preguntar
    {
        int ndia;
        public void LeerEvaluar()
        {
            Console.WriteLine("Escriba un numero de dia");
            ndia = int.Parse(Console.ReadLine());

            switch (ndia)
            {
                case 1:
                    Console.WriteLine("El dia es dia lunes");
                break;
                case 2:
                    Console.WriteLine("El dia es dia Martes");
                break;
                case 3:
                    Console.WriteLine("El dia es dia Miercoles");
                break;
                case 4:
                    Console.WriteLine("El dia es dia Jueves");
                break;
                case 5:
                    Console.WriteLine("El dia es dia Viernes");
                break;
                case 6:
                    Console.WriteLine("El dia es dia Sabado");
                break;
                case 7:
                    Console.WriteLine("El dia es dia Domingo");
                break;
                default:
                    Console.WriteLine("EL DIA ES INCORRECTO");
                break;
            }
        }
    }
}
