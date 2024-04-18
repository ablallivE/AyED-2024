using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Villalba_CalculadoraBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            Console.WriteLine("escribir el primer numero");
            numero1 = int.Parse(Console.ReadLine());
            int numero2;
            Console.WriteLine("escribir el segundo numero");
            numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("la suma es " + (numero1 + numero2));
            Console.WriteLine("la resta es " + (numero1 - numero2));
            Console.WriteLine("la multiplicacion es " + (numero1 * numero2));
            Console.WriteLine("la division es " + (numero1 / numero2));
            Console.WriteLine("el resto es " + (numero1 % numero2));


            Console.ReadKey();
        }
    }
}
