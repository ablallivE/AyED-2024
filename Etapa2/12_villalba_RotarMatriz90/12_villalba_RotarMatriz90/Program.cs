using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_villalba_RotarMatriz90
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el el valor de N y M");
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            Random aleatorio = new Random();
            int[,] matriz = new int[N, M];
            for (int c = 0; c < N; c++)
            {

                for (int f = 0; f < M; f++)
                {
                    matriz[c, f] = aleatorio.Next(0,100) ;
                    Console.Write(matriz[c, f]+"\t");

                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int[,] matriz2 = new int[N, M];
            for (int f = 0; f < M; f++)
            {

                for (int c = 0; c < N; c++)
                {
                    matriz2[c, f] = matriz[c,f];
                    Console.Write(matriz2[c, f]+"\t");

                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}