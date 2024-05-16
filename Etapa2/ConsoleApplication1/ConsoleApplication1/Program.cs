using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿cuantas vueltas hace MCqueen?");
            int[] vector = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < vector.Count(); i++)
            {
                Console.WriteLine("vuelta " + (i + 1));
                Console.WriteLine("¿en cuanto la hace ?");
                int respuesta = int.Parse(Console.ReadLine());
                if (respuesta > 2000)
                {
                    Console.WriteLine("es mucho para el Rayo, otro tiempo");
                    i--;
                }
                else
                {
                    vector[i] = respuesta;
                }
                
            }
            int acumulador = 0;
            for (int j = 0; j < vector.Count(); j++)
            {
                acumulador += vector[j];
                
            }
            int MejorVuelta = 100;
            for(int k = 0; k < vector.Count(); k++)
            {
                if(vector[k] < MejorVuelta)
                {
                    MejorVuelta = vector[k];
                }
                

            }
            Console.WriteLine("*tardo en completar la carrera en " + acumulador + " segundos*");
            Console.WriteLine("*el tiempo promedio de cada vuelta fue de " + (acumulador/vector.Count()) + " segundos*");
            Console.WriteLine("*el mejor tiempo es de " + MejorVuelta + " segundos*");


            Console.ReadKey();
        }
    }
}
