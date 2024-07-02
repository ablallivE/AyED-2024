using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_villalba_Sumando
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("matriz 1 ");
            Console.WriteLine("ingrese N y M ");
            Random aleatorio = new Random();
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[,] matriz = new int[N, M];
            for (int c = 0; c < M; c++)
            {

                for (int f = 0; f < N; f++)
                {
                    matriz[f, c] = aleatorio.Next(0, 100);
                    Console.Write(matriz[f, c] + "   ");

                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("matriz 2");           
            int[,] matriz2 = new int[N, M];
            for (int x = 0; x < M; x++)
            {

                for (int y = 0; y < N; y++)
                {
                    matriz2[y, x] = aleatorio.Next(0, 100);
                    Console.Write(matriz2[y, x] + "   ");

                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("matriz final");
            int[,] matriz3 = new int[N, M];
            for (int z = 0; z < M; z++)
            {

                for (int o = 0; o < N; o++)
                {
                    matriz3[o, z] = matriz[o, z] + matriz2[o, z];
                    Console.Write(matriz3[o, z] + "   ");

                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}