using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Villalba_EsMayor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese su edad");
            int edad;
            edad = int.Parse(Console.ReadLine());

            Console.WriteLine("tu edad es" + edad);
            if(edad < 18)
            {
                Console.WriteLine("sos menor");
            }
            else if(edad > 18)
            {
                Console.WriteLine("sos mayor de edad");
            }
            Console.ReadKey();
        }
    }
}
