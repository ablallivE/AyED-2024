using System;

namespace _14_Villalba_Estudiantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese la cantidad de Estudiantes");
            int N = int.Parse(Console.ReadLine());
            Console.Write("colocar Nombre, edad y calificacion en este orden");
            Console.WriteLine();
            string[,] matriz = new string[ 3, N];
            for (int c = 0; c < N; c++)
            {

                for (int f = 0; f < 3; f++)
                {
                    matriz[f, c] = Console.ReadLine() ;
                    
                    Console.Clear();
                }
                Console.WriteLine();
            }
            for (int c = 0; c < N;c++)
            {

                for (int f = 0; f < 3; f++)
                {
                    Console.Write(matriz[f,c] + "\t");


                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}