using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Villalba_DiezVeces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese una palabra");
            String palabra;
            palabra = Console.ReadLine();
            int contador;
            contador = 1;

            while(contador < 10)
            {
                Console.WriteLine(palabra);
                contador++;
            }
            Console.ReadKey();
        }
    }
}
