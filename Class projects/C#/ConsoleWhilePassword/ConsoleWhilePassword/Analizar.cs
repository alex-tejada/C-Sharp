using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWhilePassword
{
    public class Analizar
    {

        string pass, contra;

        public void LeerSecreto()
        {
            contra = "QWER";

            Console.WriteLine("Escribe una contrasena ");
            pass = Console.ReadLine();
            while (pass != contra)
            {
                Console.WriteLine("La contrasena es incorrecta");
                Console.WriteLine("Escribe denuevo una contrasena ");
                pass = Console.ReadLine();
            }
            Console.WriteLine("La contrasena es correcta");
        }
    }
}
