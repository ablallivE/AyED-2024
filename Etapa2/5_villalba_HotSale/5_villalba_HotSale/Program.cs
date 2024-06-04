using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_villalba_HotSale
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿cuantos productos se vendieron?");
            int[] vector = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < vector.Count(); i++)
            {
                Console.WriteLine("producto " + (i + 1));
                Console.WriteLine("¿cual es su precio ?");
                int respuesta = int.Parse(Console.ReadLine());
               
                    vector[i] = respuesta;
                

            }
            int precioMenor = 100;
            int precioMayor = 100;

            for (int k = 0; k < vector.Count(); k++)
            {

                if (vector[k] <= precioMenor)
                {
                    precioMenor = vector[k];

                }
                else
                {
                    precioMayor= vector[k];

                }

            }
            for (int i = 0; i < vector.Length; i++)
            {
                for (int j = 0; j < vector.Length - 1; j++)
                {
                    if (vector[j] < vector[j + 1])
                    {
                        int temp = vector[j];
                        vector[j] = vector[j + 1];
                        vector[j + 1] = temp;

                    }

                }

            }
            for (int i = 0; i < vector.Count(); i++)
            {
                Console.WriteLine(vector[i] + " pesos");
                
            }

            Console.WriteLine("*el producto mas caro fue de " + precioMayor +"pesos*");
            Console.WriteLine("*el producto mas barato fue de " + precioMenor + "pesos*");


            Console.ReadKey();
        }
    }
}