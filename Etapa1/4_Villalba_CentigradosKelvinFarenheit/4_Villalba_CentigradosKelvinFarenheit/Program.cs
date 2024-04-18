using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Villalba_CentigradosKelvinFarenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pone los grados celsius");
            int gradosC;
            gradosC = int.Parse(Console.ReadLine());

            Console.WriteLine("en escala Kelvin son " + (gradosC + 273));
            Console.WriteLine("en escala fahrenheit son " + ((gradosC * 18/10)+32));
            Console.ReadKey();


        }
    }
}
