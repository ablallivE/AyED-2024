using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_villalba_ZEGARPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            Console.WriteLine("¿cuantos objetos hay?");
            int[] vector = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < vector.Count(); i++)
            {
                Console.WriteLine("objeto " + (i + 1));
                Console.WriteLine("¿cual es su valor ?");
                int respuesta = aleatorio.Next(100,400 );

                vector[i] = respuesta;
                Console.WriteLine(vector[i]);

            }
            Console.WriteLine("escriba el filtro");
            int filtro = int.Parse(Console.ReadLine());
            Console.WriteLine("*estas son las posiciones de los objetos que superan el valor minimo*");

            for (int i = 0; i < vector.Count(); i++)
            {
                if (vector[i] > filtro)
                {
                    Console.WriteLine("° en la posicion " + (i + 1) + " se encuentra un objeto con valor " + vector[i] + " °");
                }
            }
            Console.ReadKey();
        }
    }
}