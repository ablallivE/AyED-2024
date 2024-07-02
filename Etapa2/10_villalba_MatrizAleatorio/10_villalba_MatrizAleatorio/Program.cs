using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_villalba_MatrizAleatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("matriz con rango random");
            Console.WriteLine("ingrese N y M ");
            Random aleatorio = new Random();
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int[,] matriz = new int[N, M];
            for (int c = 0; c < M; c++)
            {

                for (int f = 0; f < N; f++)
                {
                    matriz[f, c] = aleatorio.Next(0, 100);
                    Console.Write(matriz[f, c]+ "   ");

                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
