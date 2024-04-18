using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Villalba_LaSumaAnterior
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            Console.WriteLine("pon un numero");
            numero1 = int.Parse(Console.ReadLine());//leer un numero
            int numero2;
            Console.WriteLine("pon un numero");
            numero2 = int.Parse(Console.ReadLine());//leer un numero
            int numero3;
            Console.WriteLine("pon un numero");
            numero3 = int.Parse(Console.ReadLine());//leer un numero
            int numero4;
            numero4 = (numero1 + numero2 + numero3);
            Console.WriteLine("el numero4 es " + (numero4));

            Console.ReadKey();
        }
    }
}
