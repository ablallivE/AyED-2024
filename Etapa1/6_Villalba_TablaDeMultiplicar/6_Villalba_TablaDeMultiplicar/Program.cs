using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Villalba_TablaDeMultiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("escribir un numero");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine("la tabla del 1 al 10 de " + numero+"es la siguiente");
            Console.WriteLine(" por 1 = " + (numero * 1));
            Console.WriteLine(" por 2 = " + (numero * 2));
            Console.WriteLine(" por 3 = " + (numero * 3));
            Console.WriteLine(" por 4 = " + (numero * 4));
            Console.WriteLine(" por 5 = " + (numero * 5));
            Console.WriteLine(" por 6 = " + (numero * 6));
            Console.WriteLine(" por 7 = " + (numero * 7));
            Console.WriteLine(" por 8 = " + (numero * 8));
            Console.WriteLine(" por 9 = " + (numero * 9));
            Console.WriteLine(" por 10= " + (numero * 10));

            Console.ReadKey();


        }
    }
}
