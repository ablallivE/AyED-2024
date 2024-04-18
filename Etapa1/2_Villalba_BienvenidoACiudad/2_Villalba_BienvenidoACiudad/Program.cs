using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Villalba_BienvenidoACiudad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escribir un nombre y una ciudad");
            string nombre;
            nombre = Console.ReadLine();
            string ciudad;
            ciudad = Console.ReadLine();
            Console.WriteLine("Hola "+ nombre + " bienvenido a " + ciudad);

            Console.ReadKey();
        }
    }
}
