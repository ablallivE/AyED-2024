using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Villalba_HastaN
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("ingresar valor N");
            N = int.Parse(Console.ReadLine());

            int numero;
            numero = 1;

            while (numero < N)
            {
                numero++;
                if (numero % 2 == 0)
                {
                    Console.WriteLine(numero);
                }
            }
            Console.ReadKey();
        }
    }
}
