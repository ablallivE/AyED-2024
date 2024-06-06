using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_villalba_ContratacionSoft
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            Console.WriteLine("¿cuantos candidatos hay?");
            int[] vector = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < vector.Count(); i++)
            {
                Console.WriteLine("Participantes " + (i + 1));
                Console.WriteLine("¿cual es su puntaje   ?");
                int respuesta = aleatorio.Next(100, 400);

                vector[i] = respuesta;
                Console.WriteLine(vector[i]);

            }
            Console.WriteLine("-Orden-");
            for (int i = 0; i < vector.Length; i++)
            {
                for (int j = 0; j < vector.Length - 1; j++)
                {
                    if (vector[j] > vector[j + 1])
                    {
                        int temp = vector[j];
                        vector[j] = vector[j + 1];
                        vector[j + 1] = temp;

                    }

                }
               
            }
            for (int i = 0; i < vector.Count(); i++)
            {
                Console.WriteLine(vector[i] + " puntos");

            }

            Console.WriteLine("escriba el filtro");
            int filtro = int.Parse(Console.ReadLine());
            Console.WriteLine("*estos son los puntajes multiplos del filtro *");

            for (int i = 0; i < vector.Count(); i++)
            {
                if (vector[i] % filtro == 0 )
                {
                    Console.WriteLine("° Puntaje numero " + (i + 1) + " con valor " + vector[i] + " °");
                }
                
            }
            Console.ReadKey();
        }
    }
}