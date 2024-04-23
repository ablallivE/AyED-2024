using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Villalba_EsDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escriba 2 numeros");
            int numer1;
            numer1 = int.Parse(Console.ReadLine());

            int numer2;
            numer2 = int.Parse(Console.ReadLine());

            if (numer2 == 0)
            {
                Console.WriteLine("error");
            }
            else
            {
                int numerR;
                numerR = numer1 / numer2;

                Console.WriteLine("la division es" + numerR);
            }
            Console.ReadKey();
        }
    }
}
