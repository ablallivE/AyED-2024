using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Villalba_MiPrimerFuncion
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("¿cual es tu nombre?");
            M(Console.ReadLine());



            Console.ReadKey();
        }
        static string M(string nombre)
        {
            Console.WriteLine("¡Hola " + nombre + " !");
            return nombre;

        }
    }
}
