using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Villalba_PixelDreams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿cuantos participantes hay?");
            int[] vector = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < vector.Count(); i++)
            {
                Console.WriteLine("participante " + (i + 1));
                Console.WriteLine("¿cual es su puntaje ?");
                int respuesta = int.Parse(Console.ReadLine());
                if (respuesta > 100)
                {
                    Console.WriteLine("se paso del puntaje maximo");
                    i--;
                }
                else
                {
                    vector[i] = respuesta;
                }

            }
            int peorPuntaje = 100;
            int mejorPuntaje = 100;
            
            for (int k = 0; k < vector.Count(); k++)
            {

                if (vector[k] <= peorPuntaje)
                {
                    peorPuntaje = vector[k];
                    
                }
                else
                {
                    mejorPuntaje = vector[k];
   
                }
               
            }
            for (int i = 0; i < vector.Length; i++)
            {
                for (int j = 0; j < vector.Length - 1; j++)
                {
                    if(vector[j]<vector[j + 1])
                    {
                        int temp = vector[j];
                        vector[j] = vector[j + 1];
                        vector[j + 1] = temp;
                        
                    }
                    
                }
                
            }
          for(int i = 0; i < vector.Count(); i++)
            {
                Console.WriteLine(vector[i]);
            }

            Console.WriteLine("*el peor puntaje es de " + peorPuntaje + "puntos*");
            Console.WriteLine("*el mejor puntaje es de " + mejorPuntaje + "puntos*");


            Console.ReadKey();
        }
    }
}