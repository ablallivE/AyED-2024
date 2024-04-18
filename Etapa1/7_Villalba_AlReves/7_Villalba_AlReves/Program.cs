using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Villalba_AlReves
{
    class Program
    {
        static void Main(string[] args)
        { Console.WriteLine("ingresar 3 letras");
            string letra1;
            letra1 = Console.ReadLine();
            string letra2;
            letra2 = Console.ReadLine();
            string letra3;
            letra3 = Console.ReadLine();

            Console.WriteLine("este es el orden inicial "+letra1+ letra2+ letra3);
            Console.WriteLine("al revez "+letra3+ letra2+ letra1);

            Console.ReadKey();
        }
    }
}
