using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Villalba_CuentaRegresiva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese un numero");

            int numero;
            numero = int.Parse(Console.ReadLine());

            int contador;
            contador = numero;

            Console.WriteLine("cuenta regresiva");

            while (contador >= 0)
            {
                Console.WriteLine(contador);
                contador--;
            }
            Console.ReadKey();
        }
    }
}
