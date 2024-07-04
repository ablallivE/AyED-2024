using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_villalba_ObtenerDiagonalPrincipal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el el valor de N ");
            int N = int.Parse(Console.ReadLine());            
            Random aleatorio = new Random();
            int[,] matriz = new int[N, N];
            for (int c = 0; c < N; c++)
            {

                for (int f = 0; f < N; f++)
                {
                    matriz[c, f] = aleatorio.Next(0, 100);
                    Console.Write(matriz[c, f] + "\t");

                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int[] vector = new int[N];
            for(int i = 0; i < N ; i++)
            {
                vector[i] = matriz[i, i];
                Console.Write(vector[i] + "\t");
               
            }
           
            
            Console.ReadKey();
        }
    }
}