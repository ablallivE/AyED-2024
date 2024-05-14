using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Villalba_Homero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿cuantos obstaculos debe superar?");
            int[] vector = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < vector.Count(); i++)
            {
                Console.WriteLine("Obastaculo" + (i+1));
                Console.WriteLine("¿lo supera?");
                string respuesta = Console.ReadLine();
                if (respuesta == "si")
                {

                    vector[i] = 10;
                }
                else if (respuesta == "no")
                {
                    vector[i] = -5;
                }
                else
                {
                    Console.WriteLine("Respuesta inválida. Por favor, responda 'si' o 'no'.");
                    i--;
                }

                
            }
            int acumulador = 0;
            for (int j = 0; j < vector.Count(); j++)
            {
                acumulador += vector[j];

            }
            Console.WriteLine("tu puntaje fue de " + acumulador);

            Console.ReadKey();
        }
    }
}
