using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Villalba_ValorDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("escriba el ancho");
            x = int.Parse(Console.ReadLine());
            int y;
            Console.WriteLine("escriba el alto");
            y = int.Parse(Console.ReadLine());
   

            Console.WriteLine("el area es " + (x * y));
            Console.WriteLine("el perimetro es " + ((x * 2) + (y * 2)));
            Console.WriteLine("la diagonal es " + (Math.Sqrt((x * x) + (y * y))));

            Console.ReadKey();
                

        }
    }
}
