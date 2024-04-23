using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Villalba_Cumplidos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese su edad");
            int edad;
            edad = int.Parse(Console.ReadLine());

            int contador;
            contador = 1;

            Console.WriteLine("estos son los años que cumpliste");

            while (contador <=edad)
            {
                Console.WriteLine(contador);
                contador++;
            }
            Console.ReadKey();
        }
    }
}
