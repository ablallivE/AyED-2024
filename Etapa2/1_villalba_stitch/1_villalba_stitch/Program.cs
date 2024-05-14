using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_villalba_stitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿cuantos invitados son?");
            int[] vector = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < vector.Count(); i++)
            {
                Console.WriteLine("invitado " + (i + 1));
                Console.WriteLine("cuanto come");
                int respuesta = int.Parse(Console.ReadLine());
                if (respuesta > 100)
                {
                    Console.WriteLine("SE PASA DEL RANGO, ingrese otro numero ");
                    i--;

                }
                else if (respuesta < 1)
                {
                    Console.WriteLine("SE PASA DEL RANGO, ingrese otro numero ");
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
            Console.WriteLine("el promedio de comida es de " + (acumulador / vector.Count()));

            Console.ReadKey();
        }
    }
}