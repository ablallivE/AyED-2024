using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_villalba_MiPrimerMatirz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el el valor de N y M");
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int[,] matriz = new int[N, M];
            for (int c = 0; c < M; c++)
            {
                for (int f = 0; f < N; f++)
                {
                    matriz[f, c] = 0;
                    Console.WriteLine(matriz[f, c]);
                }

            }

            Console.ReadKey();
        }
    }
}
