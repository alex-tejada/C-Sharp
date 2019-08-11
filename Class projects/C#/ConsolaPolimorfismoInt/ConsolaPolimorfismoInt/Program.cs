using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaPolimorfismoInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Chihuahua _Chihuahua1 = new Chihuahua();
            Chihuahua _Chihuahua2 = new Chihuahua();
            Bulldog _Bulldog1 = new Bulldog();
            Bulldog _Bullddog2 = new Bulldog();
            IPerro[] _Perrera = {_Chihuahua1,_Chihuahua2,_Bulldog1,_Bullddog2 };
            foreach (var perro in _Perrera)
            {
                Console.WriteLine(perro.Ladrar());
                Console.WriteLine(perro.Dormir());
            }
            Console.ReadKey();
        }
    }
}
