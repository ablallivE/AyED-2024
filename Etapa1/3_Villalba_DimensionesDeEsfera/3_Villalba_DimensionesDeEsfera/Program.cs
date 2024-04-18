using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Villalba_DimensionesDeEsfera
{
    class Program
    {
        static void Main(string[] args)
        {
            int radio;
            Console.WriteLine("ingresar el radio");
            radio = int.Parse(Console.ReadLine());
            Console.WriteLine("la superficie de la esfera es " + (4 * 3.14 * (radio^2)));
            Console.WriteLine("el volumen de la esfera es " + (4 * 3.14)/3 * (radio^3));

            Console.ReadKey();
        }
    }
}
