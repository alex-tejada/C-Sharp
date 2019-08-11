using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWhilePassword
{
    class Program
    {
        public static void Main(string[] args)
        {
            Analizar Pregunta = new Analizar();
            Pregunta.LeerSecreto();
            Console.ReadKey();
        }
    }
}
