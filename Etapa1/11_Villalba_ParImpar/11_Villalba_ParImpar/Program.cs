using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Villalba_ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese un numero");
            int numero1;
            numero1 = int.Parse(Console.ReadLine());


            if(numero1 % 2 == 0)
            {
                Console.WriteLine( " el numero es par");
            }
            else
            {
                Console.WriteLine( " el numero es impar");
            }
            Console.ReadKey();
        }
    }
}
