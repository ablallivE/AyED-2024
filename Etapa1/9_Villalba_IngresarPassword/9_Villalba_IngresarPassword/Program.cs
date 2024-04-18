using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Villalba_IngresePassword
{
    class Program
    {
        static void Main(string[] args)
        {
            string claveR;
            claveR = "enzo1234";
            string claveP;
            Console.WriteLine("ingrese la contraseña");
            claveP = Console.ReadLine();

            if (claveP == claveR)
            {
                Console.WriteLine("es correcta");
            }
            else
            {
                Console.WriteLine("error");
            }

            Console.ReadKey();


        }
    }
}
