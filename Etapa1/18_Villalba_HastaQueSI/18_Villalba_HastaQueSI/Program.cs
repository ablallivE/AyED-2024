using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Villalba_HastaQueSI
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuesta = " ";

            Console.WriteLine("DIGA SI PARA CONTINUAR");

            while (respuesta != "SI")
            {
                Console.WriteLine("¿desea terminar el programa?");
                respuesta = Console.ReadLine();

            }

            Console.WriteLine("¡Hasta la vista!");
            Console.ReadKey();

        }
    }
}
